def retriever(img_path,
	to_file = True, 
	num_retrieve = 30, 
	coords = None):

	import cv2
	import cPickle as pickle
	import math
	import heapq
	from sklearn.cluster import MiniBatchKMeans as KMeans

	with open('tfidf', 'rb') as f:
		names, kmean, tfidf, tfidf_l2 = pickle.load(f)

	# Detect and compute SIFT
	img = cv2.imread(img_path)

	if coords is not None:
		fromx = int(coords[0])
		tox = int(coords[2])
		fromy = int(coords[1])
		toy = int(coords[3])
		img = img[fromy:toy,fromx:tox]

	gray = cv2.cvtColor(img, cv2.COLOR_BGR2GRAY)
	sift = cv2.SIFT()
	kp = sift.detect(gray,None)
	sift = cv2.SIFT()
	_, des = sift.detectAndCompute(gray,None)
	lab = kmean.predict(des)

	# Compute q_vec
	q_vec = dict()
	for term in lab:
		q_vec[term] = q_vec.get(term, 0) + 1
	q_vec = dict((term, math.log(q_vec[term],10)) for term in q_vec)

	# Compute similarities
	def get_score(d):
		d_vec = dict((term, tfidf[term].get(d, 0.0)) for term in q_vec)
		return sum(q_vec[term] * d_vec[term] for term in d_vec)/tfidf_l2[d]

	scores = []
	for d in range(len(names)):
		heapq.heappush(scores, (get_score(d), d))

	# Retrieve top
	retrieve = [names[k] for v,k in heapq.nlargest(
		num_retrieve, scores)]

	# Tofile
	if to_file:
		retrieve_text = '\n'.join(retrieve)
		with open('retrieve.txt','w') as f:
			f.write(retrieve_text)
	else:
		return retrieve
		
import sys
if __name__ == '__main__':
	retriever(sys.argv[1])