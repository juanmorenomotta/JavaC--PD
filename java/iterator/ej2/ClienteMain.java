package patrones.iterator.ej2;

public class ClienteMain {

	public static void main(String[] args) {
		AllCandidates ac = new AllCandidates();
		String selectedCandidates = "Name � - Cert Type � - Location" + "\n"
				+ " � � � � � � � � � � � � � � � � � � � ";
		while (ac.hasNext()) {
			Candidate c = (Candidate) ac.next();
			selectedCandidates = selectedCandidates + "\n" + c.getName()
					+ " - " + c.getCertificationType() + " - "
					+ c.getLocation();
		}
		System.out.println(selectedCandidates);
	}

}
