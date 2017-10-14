package patrones.iterator.ej2;

import java.util.Enumeration;
import java.util.Iterator;
import java.util.Vector;

public class AllCandidates implements Iterator {
	private Vector data;
	Enumeration ec;
	Candidate nextCandidate;

	public AllCandidates() {
		initialize();
		ec = data.elements();
	}

	private void initialize() {
		/*
		 * Get data from db.
		 */
		FileUtil util = new FileUtil();
		data = util.fileToVector("Candidates.txt");

	}

	public boolean hasNext() {
		boolean matchFound = false;
		nextCandidate = null;
		while (ec.hasMoreElements()) {
			Candidate tempObj = (Candidate) ec.nextElement();
			nextCandidate = tempObj;
			break;
		}
		return (nextCandidate != null);
	}

	public Object next(){
		if (nextCandidate != null) {
			return nextCandidate;
		}
		return null;
	}

	public void remove() {
	}
}