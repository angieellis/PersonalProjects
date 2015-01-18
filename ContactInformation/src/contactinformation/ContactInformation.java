/*
 * Angie Ellis
 * Week 3 Individual Assignment
 * Part 1
 * PRG 421
 */

package contactinformation;

import java.io.*;
import java.awt.*;
import java.awt.event.*;
import javax.swing.*;

/*
 * the ContactInformation class allows the user to enter a series of contacts' 
 * names, ages, emails, and phone numbers and writes the information to a file
 */
public class ContactInformation extends JFrame {

    //initialize variables
    private JPanel displayPanel;
    private JPanel inputPanel;
    private JPanel buttonPanel;
    private JPanel mainPanel;
    
    private JLabel header;
    private JLabel contactName;
    private JLabel contactAge;
    private JLabel contactEmail;
    private JLabel contactPhone;
    
    private JTextField name;
    private JTextField age;
    private JTextField email;
    private JTextField phone;
    
    private JButton addButton;
    private JButton clearButton;
    private JButton exitButton;
    
    //constructor
    public ContactInformation() {
        super("Contact Information");
        
        //call methods to build each panel component
        buildDisplayPanel();
        buildInputPanel();
        buildButtonPanel();
        buildMainPanel();
        
        add(mainPanel);
        
        pack();
        setVisible(true);
    }
    
    /*
     * the buildDisplayPanel method builds the panel that displays the required 
     * contact information the user is expected to input
     */
    private void buildDisplayPanel() {
        displayPanel = new JPanel();
        
        contactName = new JLabel("Contact Name:");
        contactAge = new JLabel("Contact Age:");
        contactEmail = new JLabel("Contact Email:");
        contactPhone = new JLabel("Contact Phone:");
  
        displayPanel.setLayout(new BoxLayout(displayPanel, BoxLayout.Y_AXIS));
        displayPanel.setBorder(BorderFactory.createEmptyBorder(0, 7, 0, 0));
        displayPanel.add(Box.createVerticalStrut(10));
        displayPanel.add(contactName);
        displayPanel.add(Box.createVerticalStrut(12));
        displayPanel.add(contactAge);
        displayPanel.add(Box.createVerticalStrut(12));
        displayPanel.add(contactEmail);
        displayPanel.add(Box.createVerticalStrut(12));
        displayPanel.add(contactPhone);
        displayPanel.add(Box.createVerticalStrut(10));
    }
        
    /* 
     * the buildInputPanel method builds the panel that provides fields that 
     * allow the user to input the required contact information
     */
    private void buildInputPanel() {
        inputPanel = new JPanel();
        
        name = new JTextField(15);
        age = new JTextField(15);
        email = new JTextField(15);
        phone = new JTextField(15);
        
        inputPanel.setLayout(new BoxLayout(inputPanel, BoxLayout.Y_AXIS));
        inputPanel.setBorder(BorderFactory.createEmptyBorder(5, 3, 5, 7));
        inputPanel.add(name);
        inputPanel.add(age);
        inputPanel.add(email);
        inputPanel.add(phone);
    }
    
    /*
     * the buildButtonPanel method builds the panel that provides buttons to 
     * add contact information, clear text fields, or exit the program
     */
    private void buildButtonPanel() {
        buttonPanel = new JPanel();
        
        addButton = new JButton("Add Contact");
        addButton.addActionListener(new ButtonListener());
        clearButton = new JButton("Clear");
        clearButton.addActionListener(new ButtonListener());
        exitButton = new JButton("Exit");
        exitButton.addActionListener(new ButtonListener());
        
        buttonPanel.setLayout(new BoxLayout(buttonPanel, BoxLayout.X_AXIS));
        buttonPanel.add(Box.createHorizontalStrut(12));
        buttonPanel.add(addButton);
        buttonPanel.add(clearButton);
        buttonPanel.add(exitButton);
    }
    
    /*
     * the buildMainPanel method builds the main panel that houses all other
     * panels
     */
    private void buildMainPanel() {
        mainPanel = new JPanel();
        header = new JLabel("Add Contact Information");
        header.setHorizontalAlignment(JLabel.CENTER);
        header.setBorder(BorderFactory.createEmptyBorder(5, 0, 0, 0));
        
        mainPanel.setLayout(new BorderLayout());
        mainPanel.add(header, BorderLayout.NORTH);
        mainPanel.add(displayPanel, BorderLayout.WEST);
        mainPanel.add(inputPanel, BorderLayout.EAST);
        mainPanel.add(buttonPanel, BorderLayout.SOUTH);
    }
    
    /*
     * the ButtonListener class provides action listeners for each button in the
     * buttonPanel
     */
    private class ButtonListener implements ActionListener {
        public void actionPerformed(ActionEvent e) {
            String inputAge;
            double addAge;
            
            if(e.getSource() == exitButton)
                System.exit(0);
            else if(e.getSource() == clearButton) {
                name.setText(null);
                age.setText(null);
                email.setText(null);
                phone.setText(null);
            }
            else if(e.getSource() == addButton) {  
                try {
                    inputAge = age.getText();
                    addAge = Double.parseDouble(inputAge);
                    
                    //validate age range
                    if(addAge < 0 || addAge > 120) {
                        JOptionPane.showMessageDialog(null, "Please enter a valid age.");
                    }
                    //write data input to file
                    else {
                        FileWriter fwriter = new FileWriter("ContactInfo.txt", true);
                        PrintWriter contactFile = new PrintWriter(fwriter);

                        contactFile.println(name.getText());
                        contactFile.println(age.getText());
                        contactFile.println(email.getText());
                        contactFile.println(phone.getText());

                        contactFile.close();
                        
                        //clear text fields
                        name.setText(null);
                        age.setText(null);
                        email.setText(null);
                        phone.setText(null);
                    }
                }
                catch(NumberFormatException f) {
                    JOptionPane.showMessageDialog(null, "Invalid age. Please try again.");
                }
                catch(IOException g) {
                    JOptionPane.showMessageDialog(null, g.getMessage());
                }
            } 
        }
    }
    
    /*
     * the main method creates an instance of the ContactInformation and 
     * DisplayInformation classes to demonstrate their functionality
     */
    public static void main(String[] args) {
        new ContactInformation();
        new DisplayInformation();
    }
}
