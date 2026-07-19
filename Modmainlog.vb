Module Modmainlog
    'These are global variables for the usernames and passwords. All constants
    Public generalusername As String = "GENERAL"
    Public generalpassword As Integer = 1111
    Public doctorname As String = "MOOD"
    Public pharmarcistname As String = "GOOD"
    Public pharmarcymanagename As String = "DDEVB"



    Public DashboardNeedsRefer As Boolean = False
    Public TotalRevenue As Decimal = 0.0
    'represents one drug in the system
    'drug Id
    Public Function GetNextDrugId() As Integer
        Return Modmainlog.DrugList.Count + 1

    End Function

    'total stock unit
    Public Function GetTotalStockUnits() As Integer
        If DrugList.Count = 0 Then Return 0
        Return DrugList.Where(Function(total) total.IsStocked).Sum(Function(total) total.CurrentStock)
    End Function

    'total number distinct,this will make a drug which quantity is 0 to drop out
    Public Function GetTotalDrugTypes() As Integer
        Return DrugList.Where(Function(pet) pet.IsStocked).Count
    End Function
    Public Class Drug
        Public Property Drugname As String
        Public Property Category As String
        Public Property Unit As String
        Public Property Reorderlevel As Integer
        Public Property CurrentStock As Integer
        Public Property UnitPrice As Decimal
        Public Property IsStocked As Boolean    'This is for only the stock drug
        Public Property DrugID As Integer
    End Class

    'creating a class for the prescriptions
    Public Class Prescription
        Public Property DoctorName As String
        Public Property PatientName As String
        Public Property DrugName As String
        Public Property Dosage As String
        Public Property Notes As String
        Public Property status As String
        Public Property DateSent As DateTime

        Public Property DispensedDate As DateTime
        Public Property Doctoremail As String


    End Class

    'creating a class for one item(drug) in the pharmarcist tab
    Public Class Orderdrug
        Public Property DrugName As String
        Public Property Quantity As Integer
        Public Property Unitprice As Decimal
        Public Property Totalprice As Decimal

    End Class

    'we then create a temporary memory using list just like arraylist 
    Public DrugList As New List(Of Drug)()
    Public PrescriptionList As New List(Of Prescription)()
    Public NextDrugID As Integer = 1


    'Creating a function that will allow the doctor and the pharmacist to use the stocked drug(isStock)
    'this function will retrieve every drug that is stocked
    'function(ama) ama.isStock ) is a inline lambda function
    Public Function GetStockedDrugs() As List(Of Drug)
        Return DrugList.Where(Function(Ama) Ama.IsStocked).ToList()
    End Function

    'for the pharmacy drug combobox
    'if no category is selected it bypass the category filter 
    Public Function GetStockedDrugsByCategory(category As String) As List(Of Drug)
        If String.IsNullOrEmpty(category) OrElse category = "All Categories" Then
            Return GetStockedDrugs()
        End If

        Return DrugList.Where(
            Function(cat) cat.IsStocked AndAlso cat.Category = category).ToList() 'the category must exactly match the requested category parameter
    End Function

    'this will return a distinct category, it will populate the cmb
    Public Function GetStockedCategory()
        Dim cats As New List(Of String) From {"All Categories"}  'where() will grab only the stock drugs    select() will only select the category
        Dim distinctCategory = DrugList.Where(Function(dia) dia.IsStocked).Select(Function(dia) dia.Category).Distinct().ToList  'Distinct() taking out duplicates

        cats.AddRange(distinctCategory) 'this will return the unique categories
        Return cats

    End Function

    'creating a function for the reoder level
    Public Function GetLowStockDrugs() As List(Of Drug)
        Return DrugList.Where(Function(Ama) Ama.IsStocked AndAlso Ama.CurrentStock <= Ama.Reorderlevel).ToList()
        'ama.isStock checks for an active track item       ama.currentStock <= ama.reoderlevel makes the comparison
    End Function

    'creating a function for the prescriptions 
    Public Function GetPendingPercription() As List(Of Prescription)
        Return PrescriptionList.Where(Function(pen) pen.status = "Pending").ToList
        'this will return only unprocess prescriptions
        'if the a txt is matched with Pending, then that record is unprocess
    End Function



    'when stocking we use the name of the drug
    Public Function FindstockDrug(drugName As String) As Drug
        Return DrugList.FirstOrDefault(
            Function(dry) dry.IsStocked AndAlso dry.Drugname = drugName)
        'in oder not to have the have the whole list returnig
        'we use the .FirstOrDefault, which searches druglist for a stocked(dry.isStocked) and the drug names matches the parameter(dry.drugname)
        'so if the .FirstOrDefault doesnt match a record, then it return null
    End Function

    'find the drug name
    Public Function FindDrug(drugName As String) As Drug
        Return DrugList.FirstOrDefault(
            Function(dry) dry.Drugname = drugName)
        'this will scan the druglist and get me the drugs which are out of stock
        'this look at isStock or not''''''''needs some changes but i will do that later
    End Function
End Module
