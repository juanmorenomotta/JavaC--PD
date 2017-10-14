package patrones.iterator.ej3;

import java.util.Iterator;


public class ClienteMain {

	public static void main(String[] args) {
		AllCandidates ac = new AllCandidates();
		Iterator certCandidates = ac.getCertifiedCandidates("Linux");
		String selectedCandidates = "Name � - Cert Type � - Location" + "\n"
				+ " � � � � � � � � � � � � � � � � � � � ";
		while (certCandidates.hasNext()) {
			Candidate c = (Candidate)certCandidates.next();
			selectedCandidates = selectedCandidates + "\n" + c.getName()
					+ " - " + c.getCertificationType() + " - "
					+ c.getLocation();
		}
		System.out.println(selectedCandidates);
	}

}
