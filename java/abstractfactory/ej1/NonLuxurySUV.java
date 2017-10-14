package patrones.abstractfactory.ej1;

public class NonLuxurySUV implements SUV {
	private String name;

	public NonLuxurySUV(String sName) {
		name = sName;
	}

	public String getSUVName() {
		return name;
	}

	public String getSUVFeatures() {
		return "Non-Luxury SUV Features ";
	}
}
