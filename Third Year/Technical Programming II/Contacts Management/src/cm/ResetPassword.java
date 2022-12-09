package cm;

import javax.swing.JOptionPane;
import java.sql.PreparedStatement;
import java.sql.SQLException;
import java.sql.Connection;
import java.sql.ResultSet;
import java.util.logging.Level;
import java.util.logging.Logger;
import java.awt.Frame;

/**
 *
 * @author Christoph Percival
 */
public class ResetPassword extends javax.swing.JDialog {

    /**
     * Creates new form Profile
     * @param parent
     * @param modal
     */
    
    private String username = null;
    
    public ResetPassword(Frame parent, boolean modal) {
        super(parent, modal);
        initComponents();
        //Center Form
        this.setLocationRelativeTo(null);
        //Hide Panel
        panResetContainer.setVisible(false);
    }

    /**
     * This method is called from within the constructor to initialize the form.
     * WARNING: Do NOT modify this code. The content of this method is always
     * regenerated by the Form Editor.
     */
    @SuppressWarnings("unchecked")
    // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
    private void initComponents() {

        panHeader = new javax.swing.JPanel();
        lblClose = new javax.swing.JLabel();
        lblTextHeader = new javax.swing.JLabel();
        panBody = new javax.swing.JPanel();
        lblUsername = new javax.swing.JLabel();
        txtUsername = new javax.swing.JTextField();
        btnSearch = new javax.swing.JButton();
        panResetContainer = new javax.swing.JPanel();
        txtPassword = new javax.swing.JPasswordField();
        lblPassword = new javax.swing.JLabel();
        lblVerifyPassword = new javax.swing.JLabel();
        txtVerifyPassword = new javax.swing.JPasswordField();
        chkShowHide = new javax.swing.JCheckBox();
        btnResetPassword = new javax.swing.JButton();

        setDefaultCloseOperation(javax.swing.WindowConstants.DISPOSE_ON_CLOSE);
        setUndecorated(true);
        setSize(new java.awt.Dimension(0, 0));

        panHeader.setBackground(new java.awt.Color(46, 204, 113));

        lblClose.setFont(new java.awt.Font("Tahoma", 1, 24)); // NOI18N
        lblClose.setForeground(new java.awt.Color(255, 0, 0));
        lblClose.setText("X");
        lblClose.setToolTipText("Exit");
        lblClose.setCursor(new java.awt.Cursor(java.awt.Cursor.HAND_CURSOR));
        lblClose.addMouseListener(new java.awt.event.MouseAdapter() {
            public void mouseClicked(java.awt.event.MouseEvent evt) {
                lblCloseMouseClicked(evt);
            }
        });

        lblTextHeader.setFont(new java.awt.Font("Tahoma", 1, 30)); // NOI18N
        lblTextHeader.setForeground(new java.awt.Color(255, 255, 255));
        lblTextHeader.setText("Reset Password");

        javax.swing.GroupLayout panHeaderLayout = new javax.swing.GroupLayout(panHeader);
        panHeader.setLayout(panHeaderLayout);
        panHeaderLayout.setHorizontalGroup(
            panHeaderLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(panHeaderLayout.createSequentialGroup()
                .addGap(102, 102, 102)
                .addComponent(lblTextHeader, javax.swing.GroupLayout.PREFERRED_SIZE, 256, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED, 81, Short.MAX_VALUE)
                .addComponent(lblClose, javax.swing.GroupLayout.PREFERRED_SIZE, 20, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addContainerGap())
        );
        panHeaderLayout.setVerticalGroup(
            panHeaderLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addComponent(lblTextHeader, javax.swing.GroupLayout.DEFAULT_SIZE, 60, Short.MAX_VALUE)
            .addGroup(panHeaderLayout.createSequentialGroup()
                .addContainerGap()
                .addComponent(lblClose, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                .addContainerGap())
        );

        panBody.setBackground(new java.awt.Color(44, 62, 80));
        panBody.setCursor(new java.awt.Cursor(java.awt.Cursor.DEFAULT_CURSOR));
        panBody.setLayout(null);

        lblUsername.setFont(new java.awt.Font("Tahoma", 0, 18)); // NOI18N
        lblUsername.setForeground(new java.awt.Color(236, 240, 241));
        lblUsername.setText("Username:");
        panBody.add(lblUsername);
        lblUsername.setBounds(50, 10, 100, 30);

        txtUsername.setBackground(new java.awt.Color(108, 122, 137));
        txtUsername.setFont(new java.awt.Font("Tahoma", 0, 18)); // NOI18N
        txtUsername.setForeground(new java.awt.Color(253, 227, 167));
        panBody.add(txtUsername);
        txtUsername.setBounds(150, 10, 240, 30);

        btnSearch.setBackground(new java.awt.Color(255, 255, 255));
        btnSearch.setFont(new java.awt.Font("Tahoma", 1, 14)); // NOI18N
        btnSearch.setText("Search");
        btnSearch.setToolTipText("Load Image");
        btnSearch.setCursor(new java.awt.Cursor(java.awt.Cursor.HAND_CURSOR));
        btnSearch.addMouseListener(new java.awt.event.MouseAdapter() {
            public void mouseClicked(java.awt.event.MouseEvent evt) {
                btnSearchMouseClicked(evt);
            }
        });
        panBody.add(btnSearch);
        btnSearch.setBounds(310, 44, 80, 25);

        panResetContainer.setBackground(new java.awt.Color(44, 62, 80));
        panResetContainer.setBorder(new javax.swing.border.LineBorder(new java.awt.Color(255, 255, 153), 1, true));
        panResetContainer.setLayout(null);

        txtPassword.setBackground(new java.awt.Color(108, 122, 137));
        txtPassword.setFont(new java.awt.Font("Tahoma", 0, 18)); // NOI18N
        txtPassword.setForeground(new java.awt.Color(253, 227, 167));
        panResetContainer.add(txtPassword);
        txtPassword.setBounds(150, 10, 220, 30);

        lblPassword.setFont(new java.awt.Font("Tahoma", 0, 18)); // NOI18N
        lblPassword.setForeground(new java.awt.Color(236, 240, 241));
        lblPassword.setText("New Password:");
        panResetContainer.add(lblPassword);
        lblPassword.setBounds(10, 10, 120, 30);

        lblVerifyPassword.setFont(new java.awt.Font("Tahoma", 0, 18)); // NOI18N
        lblVerifyPassword.setForeground(new java.awt.Color(236, 240, 241));
        lblVerifyPassword.setText("Verify Password:");
        panResetContainer.add(lblVerifyPassword);
        lblVerifyPassword.setBounds(10, 50, 140, 30);

        txtVerifyPassword.setBackground(new java.awt.Color(108, 122, 137));
        txtVerifyPassword.setFont(new java.awt.Font("Tahoma", 0, 18)); // NOI18N
        txtVerifyPassword.setForeground(new java.awt.Color(253, 227, 167));
        panResetContainer.add(txtVerifyPassword);
        txtVerifyPassword.setBounds(150, 50, 220, 30);

        chkShowHide.setFont(new java.awt.Font("Tahoma", 0, 18)); // NOI18N
        chkShowHide.setForeground(new java.awt.Color(255, 255, 255));
        chkShowHide.setText("Show");
        chkShowHide.setCursor(new java.awt.Cursor(java.awt.Cursor.HAND_CURSOR));
        chkShowHide.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                chkShowHideActionPerformed(evt);
            }
        });
        panResetContainer.add(chkShowHide);
        chkShowHide.setBounds(376, 30, 69, 31);

        btnResetPassword.setBackground(new java.awt.Color(242, 38, 19));
        btnResetPassword.setFont(new java.awt.Font("Tahoma", 0, 18)); // NOI18N
        btnResetPassword.setForeground(new java.awt.Color(255, 255, 255));
        btnResetPassword.setMnemonic('R');
        btnResetPassword.setText("Reset Password");
        btnResetPassword.setToolTipText("Reset Password");
        btnResetPassword.setCursor(new java.awt.Cursor(java.awt.Cursor.HAND_CURSOR));
        btnResetPassword.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btnResetPasswordActionPerformed(evt);
            }
        });
        panResetContainer.add(btnResetPassword);
        btnResetPassword.setBounds(140, 100, 190, 35);

        panBody.add(panResetContainer);
        panResetContainer.setBounds(10, 110, 450, 150);

        javax.swing.GroupLayout layout = new javax.swing.GroupLayout(getContentPane());
        getContentPane().setLayout(layout);
        layout.setHorizontalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addComponent(panHeader, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
            .addComponent(panBody, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
        );
        layout.setVerticalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(layout.createSequentialGroup()
                .addComponent(panHeader, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addGap(0, 0, 0)
                .addComponent(panBody, javax.swing.GroupLayout.PREFERRED_SIZE, 290, javax.swing.GroupLayout.PREFERRED_SIZE))
        );

        pack();
    }// </editor-fold>//GEN-END:initComponents

    private void lblCloseMouseClicked(java.awt.event.MouseEvent evt) {//GEN-FIRST:event_lblCloseMouseClicked
        // Close App
        switch(JOptionPane.showConfirmDialog(null, "Are You Sure You Want To Exit?", "Exit", JOptionPane.YES_NO_OPTION, JOptionPane.QUESTION_MESSAGE)){
            case JOptionPane.YES_OPTION -> this.dispose();
        }
    }//GEN-LAST:event_lblCloseMouseClicked

    private void chkShowHideActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_chkShowHideActionPerformed
        // Show or Hide Password
        if (chkShowHide.isSelected()){
            chkShowHide.setText("Hide");
            txtPassword.setEchoChar((char)0);
            txtVerifyPassword.setEchoChar((char)0);
        }
        else
        {
            chkShowHide.setText("Show");
            txtPassword.setEchoChar('*');
            txtVerifyPassword.setEchoChar('*');
        }
    }//GEN-LAST:event_chkShowHideActionPerformed

    private void btnResetPasswordActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnResetPasswordActionPerformed
         //DO VALIDATIONS
        //                  Password Validation
        if (!passwordIsValid())
        {
            return;
        }

        //Validation Complete. Now Send Data To Database
        switch(JOptionPane.showConfirmDialog(null, "Are You Sure You Want To Reset Your Password?", "Password Reset", JOptionPane.YES_NO_OPTION, JOptionPane.QUESTION_MESSAGE)){
            case JOptionPane.YES_OPTION -> {
                try
                {
                    Connection con = Database.getConnection();
                    PreparedStatement ps;
                    //ps = con.prepareStatement("Insert Into 'persons' ('FirstName', 'LastName', 'Username', 'Password', 'Picture') Values (?, ?, ?, ?, ?)");
                    ps = con.prepareStatement("Update persons Set Password = ? WHERE Username LIKE ?");
                    ps.setString(1, new String(txtPassword.getPassword()));
                    ps.setString(2, username);

                    //Returns number of Rows Affected, 0 if none
                    if (ps.executeUpdate() != 0)
                    {
                        JOptionPane.showMessageDialog(null, "Your Password Reset Is Successful", "Password Reset", JOptionPane.INFORMATION_MESSAGE);
                    }
                    else
                    {
                        JOptionPane.showMessageDialog(null, "Error While Resetting Your Password", "Password Reset", JOptionPane.ERROR_MESSAGE);
                    }

                    this.dispose();

                }
                catch (SQLException ex)
                {
                    JOptionPane.showMessageDialog(null, ex.getMessage(), "Password Reset", JOptionPane.ERROR_MESSAGE);
                    Logger.getLogger(ResetPassword.class.getName()).log(Level.SEVERE, null, ex);
                }
            }
        }
    }//GEN-LAST:event_btnResetPasswordActionPerformed

    private void btnSearchMouseClicked(java.awt.event.MouseEvent evt) {//GEN-FIRST:event_btnSearchMouseClicked
        username = txtUsername.getText();
         //Find Username
        try
        {
            Connection con = Database.getConnection();
            PreparedStatement ps;
            ResultSet rs;
            
            ps = con.prepareStatement("SELECT Username FROM persons WHERE Username LIKE ?");
            ps.setString(1, username);
            
            rs = ps.executeQuery();
            
            if (rs.next())
            {
                if (!(username.equals(rs.getString(1))))
                {
                    JOptionPane.showMessageDialog(null, "Username Not Found", "Username", JOptionPane.ERROR_MESSAGE);
                    //Hide Panel
                    panResetContainer.setVisible(false);
                    return;
                }
            }
            else
            {
                JOptionPane.showMessageDialog(null, "Username Not Found", "Login", JOptionPane.ERROR_MESSAGE);
                //Hide Panel
                panResetContainer.setVisible(false);
                return;
            }
        }
        catch(SQLException ex)
        {
            JOptionPane.showMessageDialog(null, ex.getMessage(), "Searching Username", JOptionPane.ERROR_MESSAGE);
            System.out.println(ex.getMessage());
            //Hide Panel
            panResetContainer.setVisible(false);
            return;
        }
        
        //Clear TextField
        txtUsername.setText("");
        
        //Show Panel
        panResetContainer.setVisible(true);
    }//GEN-LAST:event_btnSearchMouseClicked
    
    //VALIDATIONS
    //                                  Password Validation
    private boolean passwordIsValid()
    {
        String password = new String(txtPassword.getPassword());
        String verPassword = new String(txtVerifyPassword.getPassword());
        
        if (!password.equals(""))
        {
            if (!password.contains(" "))
            {
                if (password.length() < 8)
                {
                    JOptionPane.showMessageDialog(null, "Password Must Have Minimum of 8 Characters", "New Password", JOptionPane.ERROR_MESSAGE);
                    txtPassword.requestFocusInWindow();
                    return false;
                }
                
                if (password.length() > 25)
                {
                    JOptionPane.showMessageDialog(null, "Password Can Only Have Maximum of 25 Characters", "New Password", JOptionPane.ERROR_MESSAGE);
                    txtPassword.requestFocusInWindow();
                    return false;
                }
            }
            else
            {
                JOptionPane.showMessageDialog(null, "Password Cannot Contain Space Character", "New Password", JOptionPane.ERROR_MESSAGE);
                txtPassword.requestFocusInWindow();
                return false;
            }
        }
        else
        {
            JOptionPane.showMessageDialog(null, "Input New Password", "New Password", JOptionPane.QUESTION_MESSAGE);
            txtPassword.requestFocusInWindow();
            return false;
        }
        
        if (verPassword.equals(("")))
        {
            JOptionPane.showMessageDialog(null, "Verify New Password", "New Password", JOptionPane.ERROR_MESSAGE);
            txtVerifyPassword.requestFocusInWindow();
            return false;
        }
        
        //Check If Password Match
        if (!password.equals(verPassword))
        {
            JOptionPane.showMessageDialog(null, "Passwords Do Not Match", "New Password", JOptionPane.ERROR_MESSAGE);
            txtPassword.requestFocusInWindow();
            return false;
        }
        
        return true;
    }
    
    /**
     * @param args the command line arguments
     */
    public static void main(String args[]) {
        /* Set the Nimbus look and feel */
        //<editor-fold defaultstate="collapsed" desc=" Look and feel setting code (optional) ">
        /* If Nimbus (introduced in Java SE 6) is not available, stay with the default look and feel.
         * For details see http://download.oracle.com/javase/tutorial/uiswing/lookandfeel/plaf.html 
         */
        try {
            for (javax.swing.UIManager.LookAndFeelInfo info : javax.swing.UIManager.getInstalledLookAndFeels()) {
                if ("Nimbus".equals(info.getName())) {
                    javax.swing.UIManager.setLookAndFeel(info.getClassName());
                    break;
                }
            }
        } catch (ClassNotFoundException ex) {
            java.util.logging.Logger.getLogger(ResetPassword.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (InstantiationException ex) {
            java.util.logging.Logger.getLogger(ResetPassword.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (IllegalAccessException ex) {
            java.util.logging.Logger.getLogger(ResetPassword.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (javax.swing.UnsupportedLookAndFeelException ex) {
            java.util.logging.Logger.getLogger(ResetPassword.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        }
        //</editor-fold>
        //</editor-fold>
        //</editor-fold>
        //</editor-fold>

        /* Create and display the dialog */
        java.awt.EventQueue.invokeLater(new Runnable() {
            public void run() {
                ResetPassword dialog = new ResetPassword(new javax.swing.JFrame(), true);
                dialog.addWindowListener(new java.awt.event.WindowAdapter() {
                    @Override
                    public void windowClosing(java.awt.event.WindowEvent e) {
                        System.exit(0);
                    }
                });
                dialog.setVisible(true);
            }
        });
    }

    // Variables declaration - do not modify//GEN-BEGIN:variables
    private javax.swing.JButton btnResetPassword;
    private javax.swing.JButton btnSearch;
    private javax.swing.JCheckBox chkShowHide;
    private javax.swing.JLabel lblClose;
    private javax.swing.JLabel lblPassword;
    private javax.swing.JLabel lblTextHeader;
    private javax.swing.JLabel lblUsername;
    private javax.swing.JLabel lblVerifyPassword;
    private javax.swing.JPanel panBody;
    private javax.swing.JPanel panHeader;
    private javax.swing.JPanel panResetContainer;
    private javax.swing.JPasswordField txtPassword;
    private javax.swing.JTextField txtUsername;
    private javax.swing.JPasswordField txtVerifyPassword;
    // End of variables declaration//GEN-END:variables
}
