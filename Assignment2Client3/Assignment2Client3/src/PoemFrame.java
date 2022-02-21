import java.awt.BorderLayout;
import java.awt.Color;
import java.awt.EventQueue;

import javax.swing.JButton;
import javax.swing.JComboBox;
import javax.swing.JFrame;
import javax.swing.JLabel;
import javax.swing.JPanel;
import javax.swing.JTextArea;
import javax.swing.border.EmptyBorder;

public class PoemFrame extends JFrame {

	private JPanel contentPane;

	private JButton btnSearchPoem; // Added components as instance variables to 
	private JTextArea txtDisplay;  // be able to generate get methods.
	private JComboBox<String> cmbPoems;

	/**
	 * Create the frame.
	 */
	public PoemFrame() { // Autogenerated code
		setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		setBounds(100, 100, 450, 300);
		setTitle("Poem Search Client");
		contentPane = new JPanel();
		contentPane.setBorder(new EmptyBorder(5, 5, 5, 5));
		setContentPane(contentPane);
		contentPane.setLayout(null);
		contentPane.setBackground(new Color(220,238,255));
		
		btnSearchPoem = new JButton("Search");
		btnSearchPoem.setBounds(20, 106, 117, 29);
		contentPane.add(btnSearchPoem);
		
		cmbPoems = new JComboBox<String>();
		cmbPoems.setBounds(20, 41, 156, 27);
		contentPane.add(cmbPoems);
		
		cmbPoems.addItem("sea.txt"); 
		cmbPoems.addItem("sky.txt"); 
		cmbPoems.addItem("forest.txt"); 
		
		JLabel lblChoosePoem = new JLabel("Choose a poem");
		lblChoosePoem.setBounds(25, 22, 108, 16);
		contentPane.add(lblChoosePoem);
		
		txtDisplay = new JTextArea();
		txtDisplay.setBounds(220, 40, 195, 204);
		contentPane.add(txtDisplay);
		
		this.setVisible(true);
	}
	
	// Method to fetch the ComboBox cmbPoems, where the poem (file name) selection takes place
	public JComboBox<String> getCmbPoems() { 
		return cmbPoems;
	}

	// Method to fetch the JButton btnSearchPoem
	public JButton getBtnSearchPoem() {
		return btnSearchPoem;
	}

	// Method to fetch the JTextArea txtDisplay, where the poem content will be displayed
	public JTextArea getTxtDisplay() {
		return txtDisplay;
	}

}
