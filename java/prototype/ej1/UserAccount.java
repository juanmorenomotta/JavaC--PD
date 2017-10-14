package patrones.prototype.ej1;

import java.util.Vector;
/**
 * Representa una cuenta de Usuario
 *
 */
public class UserAccount implements Cloneable {
	private String userName;
	private String password;
	private String fname;
	private String lname;
	private Vector permissions = new Vector();
	
	public String toString(){
		String res ="UserName:" + userName + " Password:" + password + " Nombre:" + fname + " Apellidos:"+ lname + " Permisos:";
		for (int i=0; i<permissions.size(); i++){
			res = res + ":" + (String)permissions.get(i);
		}
		return res;
			 
	}
	public Object clone() {
		// Shallow Copy
		try {
			return super.clone();
		} catch (CloneNotSupportedException e) {
			return null;
		}
	}

	public void setUserName(String uName) {
		userName = uName;
	}

	public String getUserName() {
		return userName;
	}

	public void setPassword(String pwd) {
		password = pwd;
	}

	public String getPassword() {
		return password;
	}

	public void setFName(String name) {
		fname = name;
	}

	public String getFName() {
		return fname;
	}

	public void setLName(String name) {
		lname = name;
	}

	public String getLName() {
		return lname;
	}

	public void setPermissions(Vector rights) {
		permissions = rights;
	}

	public Vector getPermissions() {
		return permissions;
	}
}
