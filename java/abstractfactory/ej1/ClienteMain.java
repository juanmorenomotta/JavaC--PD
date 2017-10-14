package patrones.abstractfactory.ej1;

public class ClienteMain {

	public static void main(String[] args) {
		String vhCategory = "Non-Luxury"; // o se puede colocar Non-Luxury
		String vhType = "Suv"; // o se puede colocar Suv
		String searchResult = "";
		
		// get one of Luxury or NonLuxury vehicle factories
		VehicleFactory vf = VehicleFactory.getVehicleFactory(vhCategory);
		if (vhType.equals("Car")) {
			Car c = vf.getCar();
			searchResult = "Name: " + c.getCarName() + " Features: "
					+ c.getCarFeatures();
		}
		if (vhType.equals("Suv")) {
			SUV s = vf.getSUV();
			searchResult = "Name: " + s.getSUVName() + " Features: "
					+ s.getSUVFeatures();
		}
		System.out.println(searchResult);

	}
}
