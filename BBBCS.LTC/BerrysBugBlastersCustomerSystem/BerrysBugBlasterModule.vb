Imports System
Imports System.Data
Imports System.Data.SqlClient

'A module to handle all of the getting and setting of values in the various forms as well as methods used in multiple forms.
Module BerrysBugBlasterModule
    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    ' Module Member Variables
    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    Private firstName As String
    Private lastName As String
    Private address1 As String
    Private address2 As String
    Private billingAddress1 As String
    Private billingAddress2 As String
    Private city As String
    Private billingCity As String
    Private state As String
    Private billingState As String
    Private zip As Integer = 0
    Private billingZip As Integer = 0
    Private accountStatus As String
    Private servicePlan As String
    Private enrollmentDate As Date
    Private nextServiceDate As Date
    Private phoneNumber As String
    Private accountNum As Integer
    Private Const accountIncrementer = 1 ' a hard coded incrementer
    Private paymentType As String
    Private checkNumber As Integer
    Private cardType As String
    Private cardNumber As String
    Private cardExpiration As Date
    Private selectedAccount As Integer = -1
    Private lookupVal As String
    Private lookupValInt As Integer
    Private lookupCategory As String

    ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    ' Getters and Setters
    ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

    Public Function getFirstName() As String
        Return firstName
    End Function

    Public Sub setFirstName(f As String)
        firstName = f
    End Sub

    Public Function getLastName() As String
        Return lastName
    End Function

    Public Sub setLastName(l As String)
        lastName = l
    End Sub

    Public Function getAddress1() As String
        Return address1
    End Function

    Public Sub setAddress1(a As String)
        address1 = a
    End Sub

    Public Function getAddress2() As String
        Return address2
    End Function

    Public Sub setAddress2(a As String)
        address2 = a
    End Sub

    Public Function getBillingAddress1() As String
        Return billingAddress1
    End Function

    Public Sub setBillingAddress1(a As String)
        billingAddress1 = a
    End Sub

    Public Function getBillingAddress2() As String
        Return billingAddress2
    End Function

    Public Sub setBillingAddress2(a As String)
        billingAddress2 = a
    End Sub

    Public Function getZip() As Integer
        Return zip
    End Function

    Public Sub setZip(z As Integer)
        zip = z
    End Sub

    Public Function getBillingZip() As Integer
        Return billingZip
    End Function

    Public Sub setBillingZip(z As Integer)
        billingZip = z
    End Sub

    Public Function getCity() As String
        Return city
    End Function

    Public Sub setCity(c As String)
        city = c
    End Sub

    Public Function getBillingCity() As String
        Return billingCity
    End Function

    Public Sub setBillingCity(c As String)
        billingCity = c
    End Sub

    Public Function getState() As String
        Return state
    End Function

    Public Sub setState(s As String)
        state = s
    End Sub

    Public Function getBillingState() As String
        Return billingState
    End Function

    Public Sub setBillingState(s As String)
        billingState = s
    End Sub

    Public Sub setAccountStatus(s As String)
        accountStatus = s
    End Sub

    Public Function getAccountStatus() As String
        Return accountStatus
    End Function

    Public Sub setServicePlan(s As String)
        servicePlan = s
    End Sub

    Public Function getServicePlan() As String
        Return servicePlan
    End Function

    Public Sub setEnrollmentDate(d As Date)
        enrollmentDate = CDate(d.ToString("MM/dd/yyyy", System.Globalization.CultureInfo.InvariantCulture))
    End Sub

    Public Function getEnrollmentDate() As Date
        Return enrollmentDate
    End Function

    Public Sub setNextServiceDate(d As Date)
        nextServiceDate = CDate(d.ToString("MM/dd/yyyy", System.Globalization.CultureInfo.InvariantCulture))
    End Sub

    Public Function getNextServiceDate() As Date
        Return nextServiceDate
    End Function

    Public Sub setPhoneNumber(n As String)
        phoneNumber = n
    End Sub

    Public Function getPhoneNumber() As String
        Return phoneNumber
    End Function

    Public Sub setAccountNumber(n As Integer)
        accountNum = n + accountIncrementer   ' an incrementer to accountNumber
    End Sub

    Public Function getAccountNumber() As Integer
        Return accountNum
    End Function

    Public Sub setPaymentType(p As String)
        paymentType = p
    End Sub

    Public Function getPaymentType() As String
        Return paymentType
    End Function

    Public Sub setCheckNumber(c As Integer)
        checkNumber = c
    End Sub

    Public Function getCheckNumber() As Integer
        Return checkNumber
    End Function

    Public Sub setCardType(c As String)
        cardType = c
    End Sub

    Public Function getCardType() As String
        Return cardType
    End Function

    Public Sub setCardNumber(c As String)
        cardNumber = c
    End Sub

    Public Function getCardNumber() As String
        Return cardNumber
    End Function

    Public Sub setCardExpiration(d As Date)
        cardExpiration = CDate(d.ToString("MM/dd/yyyy", System.Globalization.CultureInfo.InvariantCulture))
    End Sub

    Public Function getCardExpiration() As Date
        Return cardExpiration
    End Function

    Public Sub setSelectedAccount(a As Integer)
        selectedAccount = a
    End Sub

    Public Function getSelectedAccount() As Integer
        Return selectedAccount
    End Function

    Public Sub setLookupVal(a As String)
        lookupVal = a
    End Sub

    Public Function getLookupVal() As String
        Return lookupVal
    End Function

    Public Sub setLookupValInt(a As Integer)
        lookupValInt = a
    End Sub

    Public Function getLookupValInt() As Integer
        Return lookupValInt
    End Function

    Public Sub setLookupCategory(a As String)
        lookupCategory = a
    End Sub

    Public Function getLookupCategory() As String
        Return lookupCategory
    End Function

    'A sub to copy the address information to billing information
    Public Sub setAddressInformationToBillingInformation()
        setBillingAddress1(address1) ' setting the billing address to the address line1
        setBillingAddress2(address2)  ' setting the billing address to the address line2
        setBillingCity(city)  ' setting the billing city to the adress city
        setBillingState(state) ' setting the billing state to the addresses state
        setBillingZip(zip) ' setting the billing zip to the address zip
    End Sub

    'A sub to clear the Address Information
    Public Sub clearAddressInformation()
        setAddress1("")
        setAddress2("")
        setCity("")
        setState("")
        setZip(0)
    End Sub

    'A sub to clear the billing information
    Public Sub clearBillingInformation()
        setBillingAddress1("")
        setBillingAddress2("")
        setBillingCity("")
        setBillingState("")
        setBillingZip(0)
    End Sub
End Module


'' Function for additional validating events
'Public Function validateField(length As Integer) As Boolean
'    If length = 0 Then
'        Return False
'    Else
'        Return True
'    End If
'End Function
