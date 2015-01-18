/*
 * Angie Ellis
 * Week 3 Individual Assignment
 * Part 2
 * PRG 421
 */

package contactinformation;

import java.io.*;
import java.awt.*;
import javax.swing.*;
import javax.swing.table.*;

/*
 * the DisplayInformation class reads in contact information from a data file
 * and displays it in a table within a JFrame
 */
public class DisplayInformation extends JFrame {
    //initialize variables
    private JFrame mainFrame;
    private JLabel header;
    private JTable infoTable;
    private DefaultTableModel tableModel;
    private JScrollPane scrollPane;
    
    private Object[] rowData;
    private Object[] columnNames = { "Name", "Age", "Email", "Phone" };
    
    //constructor
    public DisplayInformation() {
        
        buildTable();
        buildFrame();
        
        mainFrame.setTitle("Contact Information");
        mainFrame.setVisible(true);
        mainFrame.setSize(500, 300);
    }
    
    /*
     * the buildTable method reads data from a file and inputs it into a JTable
     *
     */
    private void buildTable() {
        rowData = new Object[4];
        infoTable = new JTable();
        tableModel = new DefaultTableModel();
        tableModel.setColumnIdentifiers(columnNames);
        infoTable.setModel(tableModel);
        String line;
        
        try {
            FileInputStream fin = new FileInputStream("ContactInfo.txt");
            BufferedReader br = new BufferedReader(new InputStreamReader(fin)); 
           
            while((line = br.readLine()) != null)
            {
                rowData[0] = line;
                for(int i = 1; i < 4; i++) {
                    rowData[i] = br.readLine();
                }
                tableModel.addRow(rowData);
            } 
            br.close();
        }
        catch (FileNotFoundException e) {
            JOptionPane.showMessageDialog(null, e.getMessage());
        }
        catch (IOException e) {
            JOptionPane.showMessageDialog(null, e.getMessage());
        }
    }
    
    /*
     * the buildFrame method builds the frame that houses the table with the
     * contact information read in from the data file
     */
    private void buildFrame() {
        mainFrame = new JFrame();
        header = new JLabel("View Contact Information");
        header.setHorizontalAlignment(JLabel.CENTER);
        header.setBorder(BorderFactory.createEmptyBorder(5, 0, 0, 0));
                
        infoTable.setFillsViewportHeight(true);
        infoTable.setShowGrid(true);
        infoTable.setVisible(true);
        scrollPane = new JScrollPane(infoTable);

        mainFrame.add(header, BorderLayout.NORTH);
        mainFrame.add(scrollPane, BorderLayout.CENTER);
    }
}
 