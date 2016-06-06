package co.uk.devchronicles.forum;

public class User {
	private int ID;
	private String Firstname;
	private String Lastname;
	public User(int _id, String _firstname, String _lastname) {
		ID = _id;
		Firstname = _firstname;
		Lastname = _lastname;
	}
	public int getID() {
		return ID;
	}
	public void setID(int iD) {
		ID = iD;
	}
	public String getFirstname() {
		return Firstname;
	}
	public void setFirstname(String firstname) {
		Firstname = firstname;
	}
	public String getLastname() {
		return Lastname;
	}
	public void setLastname(String lastname) {
		Lastname = lastname;
	}
}
