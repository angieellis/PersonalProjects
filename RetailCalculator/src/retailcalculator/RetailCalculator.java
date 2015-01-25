/*
 * Angie Ellis
 * PRG 421
 * Week 2 Individual Assignment
 */

package retailcalculator;

import java.text.DecimalFormat;
import java.awt.*;
import java.awt.event.*;
import javax.swing.*;
/*
 * Retail calculator class including a calculator that allows retailers to enter 
 * product information, calculate the discounted price, display the information, 
 * and indicate the corresponding store department
 */
public class RetailCalculator extends JFrame {

    //initialize variables
    private JPanel mainPanel;
    private JPanel headerPanel;
    private JPanel labelPanel;
    private JPanel buttonPanel;
    private JPanel inputPanel;
    private JPanel displayPanel;
    
    private JLabel messageLabel;
    private JLabel departmentLabel;
    
    private JLabel nameLabel;
    private JLabel priceLabel;
    private JLabel discountLabel;
    
    private JLabel display;
    private JLabel newPrice;
    
    private JTextField itemName;
    private JTextField itemPrice;
    private JTextField itemDiscount;
    
    private JButton calculateButton;
    private JButton exitButton;
    
    private JMenuBar menuBar;
    private JMenu deptMenu;
    private JMenuItem clothing;
    private JMenuItem home;
    private JMenuItem electronics;
    private JMenuItem beauty;
    private JMenuItem grocery;
    
    //constructor
    public RetailCalculator() {
        
        super("Retail Calculator");
                
        buildMainPanel();
        
        add(mainPanel);
        
        pack();
        setVisible(true);
    }
          
    /* 
     * method to build the main display panel that includes nested panel 
     * components and a menu bar
     */
    private void buildMainPanel() {
        mainPanel = new JPanel();
        menuBar = new JMenuBar();

        //call methods to build nested panels
        buildMenu();
        buildHeaderPanel();
        buildLabelPanel();
        buildButtonPanel();
        buildInputPanel();
        buildDisplayPanel();
        
        mainPanel.setLayout(new BorderLayout());
        mainPanel.setBorder(BorderFactory.createEmptyBorder(10, 10, 10, 10));
        
        mainPanel.add(headerPanel, BorderLayout.NORTH);
        mainPanel.add(labelPanel, BorderLayout.WEST);
        mainPanel.add(inputPanel, BorderLayout.CENTER);
        mainPanel.add(displayPanel, BorderLayout.EAST);
        mainPanel.add(buttonPanel, BorderLayout.SOUTH);
        
        menuBar.add(deptMenu);
        setJMenuBar(menuBar);
    }
    
    /*
     * method to build file menu that includes allows users to select store
     * departments as menu items
     */
    private void buildMenu() {
        
        clothing = new JMenuItem("Clothing");
        clothing.addActionListener(new DepartmentListener());
        
        home = new JMenuItem("Home");
        home.addActionListener(new DepartmentListener());

        electronics = new JMenuItem("Electronics");
        electronics.addActionListener(new DepartmentListener());

        beauty = new JMenuItem("Beauty");
        beauty.addActionListener(new DepartmentListener());

        grocery = new JMenuItem("Grocery");
        grocery.addActionListener(new DepartmentListener());

        deptMenu = new JMenu("Department");
        
        deptMenu.add(clothing);
        deptMenu.add(home);
        deptMenu.add(electronics);
        deptMenu.add(beauty);
        deptMenu.add(grocery);
    }
    
    /* 
     * method to build panel nested in the top compartment of borderlayout
     * that includes header labels
     */
    private void buildHeaderPanel() {
        headerPanel = new JPanel();
        messageLabel = new JLabel("Calculate Discounted Prices");
        departmentLabel = new JLabel("(Please select a department from the menu)");
        
        messageLabel.setHorizontalAlignment(JLabel.CENTER);
        departmentLabel.setHorizontalAlignment(JLabel.CENTER);
        
        headerPanel.setLayout(new BorderLayout());
        headerPanel.setBorder(BorderFactory.createEmptyBorder(3, 3, 3, 3));
        
        headerPanel.add(messageLabel, BorderLayout.NORTH);
        headerPanel.add(departmentLabel, BorderLayout.CENTER);        
    }
    
    /* 
     * method to build panel nested in the west compartment of borderlayout
     * that includes labels for expected input in text fields
     */
    private void buildLabelPanel() {
        labelPanel = new JPanel();
        nameLabel = new JLabel("Item Name:");
        priceLabel = new JLabel("Item Price:");
        discountLabel = new JLabel("Discount:");
        
        labelPanel.setLayout(new BorderLayout(15, 15));
        labelPanel.setBorder(BorderFactory.createEmptyBorder(3, 3, 3, 3));
        
        labelPanel.add(nameLabel, BorderLayout.NORTH);
        labelPanel.add(priceLabel, BorderLayout.CENTER);
        labelPanel.add(discountLabel, BorderLayout.SOUTH);
    }
    
    /* 
     * method to build panel nested in the center compartment of borderlayout
     * that includes text fields to gather input from user
     */
    private void buildInputPanel() {
        inputPanel = new JPanel();
        
        itemName = new JTextField(20);
        itemPrice = new JTextField(20);
        itemDiscount = new JTextField(20);
        
        inputPanel.setLayout(new BorderLayout());
        inputPanel.setBorder(BorderFactory.createEmptyBorder(3, 3, 3, 3));
        
        inputPanel.add(itemName, BorderLayout.NORTH);
        inputPanel.add(itemPrice, BorderLayout.CENTER);
        inputPanel.add(itemDiscount, BorderLayout.SOUTH);
    }
    
    /* 
     * method to build panel nested in the east compartment of borderlayout
     * that includes labels for output of calculated price
     */
    private void buildDisplayPanel() {
        displayPanel = new JPanel();
        
        display = new JLabel("Discounted price:");
        newPrice = new JLabel("$");
        
        displayPanel.setLayout(new BoxLayout(displayPanel, BoxLayout.Y_AXIS));
        displayPanel.setBorder(BorderFactory.createEmptyBorder(3, 3, 3, 3));
        
        displayPanel.add(display);
        displayPanel.add(newPrice);
    }
    
    /*
     * method to build panel nested in the south compartment of borderlayout
     * that includes buttons for calculating prices or exiting the program
     */
    private void buildButtonPanel() {
        buttonPanel = new JPanel();
        
        calculateButton = new JButton("Calculate");
        calculateButton.addActionListener(new ButtonListener());
        
        exitButton = new JButton("Exit");
        exitButton.addActionListener(new ButtonListener());
        
        buttonPanel.setLayout(new BorderLayout());
        buttonPanel.setBorder(BorderFactory.createEmptyBorder(3, 3, 3, 3));
        
        buttonPanel.add(calculateButton, BorderLayout.NORTH);
        buttonPanel.add(exitButton, BorderLayout.CENTER);
    }
    
    /* 
     * method to handle an action event of the selection of a menu item;
     * assigns selected item to the bottom header label text
     */
    private class DepartmentListener implements ActionListener {
        public void actionPerformed(ActionEvent e) {
            if(e.getSource() == clothing)
                departmentLabel.setText("Clothing Department");
            else if(e.getSource() == home) 
                departmentLabel.setText("Home Department");
            else if(e.getSource() == electronics)
                departmentLabel.setText("Electronics Department");
            else if(e.getSource() == beauty)
                departmentLabel.setText("Beauty Department");
            else if(e.getSource() == grocery)
                departmentLabel.setText("Grocery Department"); 
        }    
    }
    
    /* 
     * method to handle an action event of clicking a button;
     * calculate button calculates the discounted price using the user input
     * from text fields and displays the result in the display panel label text
     */
    private class ButtonListener implements ActionListener {
        public void actionPerformed(ActionEvent e) {
            String inputPrice;
            String inputDiscount;
            
            double price;
            double discount;
            double result;
            
            if(e.getSource() == exitButton)
                System.exit(0);
            
            else if(e.getSource() == calculateButton) {
                
                inputPrice = itemPrice.getText();
                price = Double.parseDouble(inputPrice);
                
                inputDiscount = itemDiscount.getText();
                discount = Double.parseDouble(inputDiscount);
                
                result = price - (price * discount);
                
                DecimalFormat df = new DecimalFormat("#.00");
                String format = df.format(result);
                
                newPrice.setText("$ " + format);                
            }
        }
    }
    
    //method to create an instance of the class and demonstrate its function
    public static void main(String[] args) {
        new RetailCalculator();
    }
    
}
