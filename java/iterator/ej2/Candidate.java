package patrones.iterator.ej2;

public class Candidate {

	private String name;
	private String certificationType;
	private String location;

	public Candidate(String name, String certificationType, String location) {
		super();
		this.name = name;
		this.certificationType = certificationType;
		this.location = location;
	}

	public String getName() {
		return name;
	}

	public void setName(String name) {
		this.name = name;
	}

	public String getCertificationType() {
		return certificationType;
	}

	public void setCertificationType(String certificationType) {
		this.certificationType = certificationType;
	}

	public String getLocation() {
		return location;
	}

	public void setLocation(String location) {
		this.location = location;
	}
}
