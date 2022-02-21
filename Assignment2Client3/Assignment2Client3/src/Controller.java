import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.rmi.RemoteException;

import org.tempuri.HyggeServiceSoapProxy;

public class Controller {
	private PoemFrame poemFrame; // Reference to PoemFrame as an instance variable
	private HyggeServiceSoapProxy proxy; // Reference to the SoapProxy as an instance variable
	
	public Controller(PoemFrame poemFrame) {
		this.poemFrame = poemFrame; // Assign the poemFrame input as our this.poemFrame instance variable
		this.proxy = new HyggeServiceSoapProxy(); // Create instance of the SoapProxy.
		this.defineListeners(); // Define the actionListeners so the GUI responds to user input
	}
	
	// A method that defines the actions of the components in the GUI.
	public void defineListeners() {
		poemFrame.getBtnSearchPoem().addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				String fileName = poemFrame.getCmbPoems().getSelectedItem().toString(); // Fetch file name from chosen poem in the drop down
				try {
					String poemContent = proxy.fetchPoem(fileName); // Use file name and the proxy to get the file content contained in the file with name fileName
					poemFrame.getTxtDisplay().setText(poemContent); // Display the file content in the text area in the GUI
				} catch (RemoteException e1) { // Catches any remote exceptions from the web service
					e1.printStackTrace();
				}
			}
		});
	}
}
