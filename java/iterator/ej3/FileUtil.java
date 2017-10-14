package patrones.iterator.ej3;

import java.io.BufferedReader;
import java.io.File;
import java.io.FileReader;
import java.io.IOException;
import java.util.Vector;

public class FileUtil {

	public Vector fileToVector(String file) {
		Vector v = new Vector();
		File f = new File(file);
		try {
			FileReader fr = new FileReader(f);
			BufferedReader br = new BufferedReader(fr);
			String fila;
			while ((fila = br.readLine()) != null) {
				// String.split(�,�): Parte en campos los datos y los
				// almacena en un array de Strings
				String[] campos = fila.split(",");
				String name = campos[0].trim();
				String certificationType = campos[1];
				String location = campos[2];

				v.add(new Candidate(name, certificationType, location));
			}
			
		} catch (IOException e) {
			System.out.println("Error cargando el archivo: " + e.getMessage());
		} catch (Exception e) {
			System.out.println("Error cargando el archivo: " + e.getMessage());
		}
		return v;
	}
}
