package patrones.iterator.ej3;

import java.util.Enumeration;
import java.util.Iterator;
import java.util.StringTokenizer;
import java.util.Vector;

public class AllCandidates {
	private Vector data;

	public AllCandidates() {
		initialize();
	}

	private void initialize() {
		/*
		 * Get data from db.
		 */
		data = new Vector();
		FileUtil util = new FileUtil();
		data = util.fileToVector("Candidates.txt");
		
	}

	public Enumeration getAllCandidates() {
		return data.elements();
	}

	public Iterator getCertifiedCandidates(String type) {
		return new CertifiedCandidates(this, type);
	}
}