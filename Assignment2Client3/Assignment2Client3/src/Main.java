
public class Main {

	public static void main(String[] args) {
		PoemFrame frame = new PoemFrame(); // Create PoemFrame instance to initialize GUI
		Controller controller = new Controller(frame); // Create controller instance, which contains the proxy
		controller.defineListeners(); // Use controller instance to define the actionListeners so the
	}								  // GUI responds to user input

}
