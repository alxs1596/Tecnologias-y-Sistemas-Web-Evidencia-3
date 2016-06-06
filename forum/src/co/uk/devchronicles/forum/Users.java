package co.uk.devchronicles.forum;

import java.util.ArrayList;

import javax.json.Json;
import javax.json.JsonArrayBuilder;
import javax.json.JsonObjectBuilder;
import javax.ws.rs.ApplicationPath;
import javax.ws.rs.GET;
import javax.ws.rs.Path;
import javax.ws.rs.PathParam;
import javax.ws.rs.Produces;
import javax.ws.rs.core.Application;
import javax.ws.rs.core.MediaType;
import javax.ws.rs.core.Response;

@ApplicationPath("/")
@Path("users")
public class Users extends Application {
	@GET
	@Produces(MediaType.APPLICATION_JSON)
	public Response getUsers(){
		ArrayList<User> allUsers = this.findAllUsers();
		JsonArrayBuilder jsonArrayBuilder = Json.createArrayBuilder();
		JsonObjectBuilder obj = Json.createObjectBuilder();
		for(User user : allUsers){
			jsonArrayBuilder.add(
					Json.createObjectBuilder()
						.add("id", user.getID())
						.add("firstname", user.getFirstname())
						.add("lastname", user.getLastname())
			);
		}
		obj.add("list",jsonArrayBuilder);
		return Response.ok(obj.build()).build();
	}
	
	public ArrayList<User> findAllUsers(){
		ArrayList<User> allUsers = new ArrayList<>();
		allUsers.add(new User(123456, "Alex", "Theedom"));
		allUsers.add(new User(987654, "Murat", "Yener"));
		return allUsers;
	}
	
	@GET
	@Path("/{id}")
	@Produces(MediaType.APPLICATION_JSON)
	public Response getUser(@PathParam("id") int id){
		User user = this.findUser(id);
		
		JsonObjectBuilder obj = Json.createObjectBuilder();
		obj
			.add("id", user.getID())
			.add("firstname", user.getFirstname())
			.add("lastname", user.getLastname())
		;
		
		return Response.ok(obj.build()).build();
	}
	
	public User findUser(int id){
		if (id == 123456)
			return new User(123456, "Alex","Theedom");
		if (id == 987654)
			return new User(987654, "Murat", "Yener");
		return new User(0,"","");
	}  
}
