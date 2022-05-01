


Imports System.Data.SqlServerCe
Imports dllG3Bce.Utility
Imports dllG3Bce
Imports System.Data
Imports System.Collections.Generic
Imports dllG3Bce.dstDocum
Imports dllG3Bce.dstDocumTableAdapters

Partial Public Class dstConfig

  Public Delegate Sub TabCtrlDocRowChangeEventHandler(ByVal sender As Object, ByVal e As TabCtrlDocRowChangeEvent)

  '_______________________________________________________________________________________________________________________________________________

  <Global.System.Xml.Serialization.XmlSchemaProviderAttribute("GetTypedTableSchema")>
  Partial Public Class TabCtrlDocDataTable
    Inherits Global.System.Data.DataTable
    Implements Global.System.Collections.IEnumerable

    Private columnCDCodice As Global.System.Data.DataColumn

    Private columnCDDescrizione As Global.System.Data.DataColumn

    Private columnCDCodCau As Global.System.Data.DataColumn

    Private columnCDFlgDisab As Global.System.Data.DataColumn

    Private columnCDOper1 As Global.System.Data.DataColumn

    Private columnCDOperatore As Global.System.Data.DataColumn

    Private columnCDOper2Val As Global.System.Data.DataColumn

    Private columnCDOper2Tipo As Global.System.Data.DataColumn

    Private columnCDFlgBloc As Global.System.Data.DataColumn

    Private columnCDFlgOnlyEnd As Global.System.Data.DataColumn

    Private columnCDMessaggio As Global.System.Data.DataColumn

    Private columnCDCodCnn As Global.System.Data.DataColumn

    Private columnCDOrdine As Global.System.Data.DataColumn





    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>
    Public Sub New()
      MyBase.New
      Me.TableName = "TabCtrlDoc"
      Me.BeginInit()
      Me.InitClass()
      Me.EndInit()
    End Sub

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>
    Friend Sub New(ByVal table As Global.System.Data.DataTable)
      MyBase.New
      Me.TableName = table.TableName
      If (table.CaseSensitive <> table.DataSet.CaseSensitive) Then
        Me.CaseSensitive = table.CaseSensitive
      End If
      If (table.Locale.ToString <> table.DataSet.Locale.ToString) Then
        Me.Locale = table.Locale
      End If
      If (table.Namespace <> table.DataSet.Namespace) Then
        Me.Namespace = table.Namespace
      End If
      Me.Prefix = table.Prefix
      Me.MinimumCapacity = table.MinimumCapacity
    End Sub

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>
    Public ReadOnly Property CDCodiceColumn() As Global.System.Data.DataColumn
      Get
        Return Me.columnCDCodice
      End Get
    End Property

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>
    Public ReadOnly Property CDDescrizioneColumn() As Global.System.Data.DataColumn
      Get
        Return Me.columnCDDescrizione
      End Get
    End Property

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>
    Public ReadOnly Property CDCodCauColumn() As Global.System.Data.DataColumn
      Get
        Return Me.columnCDCodCau
      End Get
    End Property

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>
    Public ReadOnly Property CDFlgDisabColumn() As Global.System.Data.DataColumn
      Get
        Return Me.columnCDFlgDisab
      End Get
    End Property

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>
    Public ReadOnly Property CDOper1Column() As Global.System.Data.DataColumn
      Get
        Return Me.columnCDOper1
      End Get
    End Property

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>
    Public ReadOnly Property CDOperatoreColumn() As Global.System.Data.DataColumn
      Get
        Return Me.columnCDOperatore
      End Get
    End Property

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>
    Public ReadOnly Property CDOper2ValColumn() As Global.System.Data.DataColumn
      Get
        Return Me.columnCDOper2Val
      End Get
    End Property

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>
    Public ReadOnly Property CDOper2TipoColumn() As Global.System.Data.DataColumn
      Get
        Return Me.columnCDOper2Tipo
      End Get
    End Property

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>
    Public ReadOnly Property CDFlgBlocColumn() As Global.System.Data.DataColumn
      Get
        Return Me.columnCDFlgBloc
      End Get
    End Property

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>
    Public ReadOnly Property CDFlgOnlyEndColumn() As Global.System.Data.DataColumn
      Get
        Return Me.columnCDFlgOnlyEnd
      End Get
    End Property

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>
    Public ReadOnly Property CDMessaggioColumn() As Global.System.Data.DataColumn
      Get
        Return Me.columnCDMessaggio
      End Get
    End Property

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>
    Public ReadOnly Property CDCodCnnColumn() As Global.System.Data.DataColumn
      Get
        Return Me.columnCDCodCnn
      End Get
    End Property

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>
    Public ReadOnly Property CDOrdineColumn() As Global.System.Data.DataColumn
      Get
        Return Me.columnCDOrdine
      End Get
    End Property

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>
    Public ReadOnly Property Count() As Integer
      Get
        Return Me.Rows.Count
      End Get
    End Property

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>
    Default Public ReadOnly Property Item(ByVal index As Integer) As TabCtrlDocRow
      Get
        Return CType(Me.Rows(index), TabCtrlDocRow)
      End Get
    End Property

    Public Event TabCtrlDocRowChanging As TabCtrlDocRowChangeEventHandler

    Public Event TabCtrlDocRowChanged As TabCtrlDocRowChangeEventHandler

    Public Event TabCtrlDocRowDeleting As TabCtrlDocRowChangeEventHandler

    Public Event TabCtrlDocRowDeleted As TabCtrlDocRowChangeEventHandler

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>
    Public Overloads Sub AddTabCtrlDocRow(ByVal row As TabCtrlDocRow)
      Me.Rows.Add(row)
    End Sub

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>
    Public Overloads Function AddTabCtrlDocRow(ByVal CDCodice As Integer, ByVal CdDescrizione As String, ByVal CdCodCau As String, ByVal CDFlgDisab As Integer, ByVal CDOper1 As String, ByVal CDOperatore As String, ByVal CDOper2Val As String, ByVal CDOper2Tipo As Integer, ByVal CDFlgBloc As Boolean, ByVal CDFlgOnlyEnd As Integer, ByVal CDMessaggio As String, ByVal CDCodCnn As Byte, ByVal CDOrdine As Integer, ByVal CDStrQry As String) As TabCtrlDocRow
      Dim rowTabCtrlDocRow As TabCtrlDocRow = CType(Me.NewRow, TabCtrlDocRow)
      Dim columnValuesArray() As Object = New Object() {CDCodice, CdDescrizione, CdCodCau, CDFlgDisab, CDOper1, CDOperatore, CDOper2Val, CDOper2Tipo, CDFlgBloc, CDFlgOnlyEnd, CDMessaggio, CDCodCnn, CDOrdine, CDStrQry}
      rowTabCtrlDocRow.ItemArray = columnValuesArray
      Me.Rows.Add(rowTabCtrlDocRow)
      Return rowTabCtrlDocRow
    End Function

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>
    Public Overridable Function GetEnumerator() As Global.System.Collections.IEnumerator Implements Global.System.Collections.IEnumerable.GetEnumerator
      Return Me.Rows.GetEnumerator
    End Function

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>
    Public Overrides Function Clone() As Global.System.Data.DataTable
      Dim cln As TabCtrlDocDataTable = CType(MyBase.Clone, TabCtrlDocDataTable)
      cln.InitVars()
      Return cln
    End Function

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>
    Protected Overrides Function CreateInstance() As Global.System.Data.DataTable
      Return New TabCtrlDocDataTable
    End Function

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>
    Friend Sub InitVars()
      Me.columnCDCodice = MyBase.Columns("CDCodice")
      Me.columnCDDescrizione = MyBase.Columns("CDDescrizione")
      Me.columnCDCodCau = MyBase.Columns("CDCodCau")
      Me.columnCDFlgDisab = MyBase.Columns("CDFlgDisab")
      Me.columnCDOper1 = MyBase.Columns("CDOper1")
      Me.columnCDOperatore = MyBase.Columns("CDOperatore")
      Me.columnCDOper2Val = MyBase.Columns("CDOper2Val")
      Me.columnCDOper2Tipo = MyBase.Columns("CDOper2Tipo")
      Me.columnCDFlgBloc = MyBase.Columns("CDFlgBloc")
      Me.columnCDFlgOnlyEnd = MyBase.Columns("CDFlgOnlyEnd")
      Me.columnCDMessaggio = MyBase.Columns("CDMessaggio")
      Me.columnCDCodCnn = MyBase.Columns("CDCodCnn")
      Me.columnCDOrdine = MyBase.Columns("CDOrdine")
    End Sub

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>
    Private Sub InitClass()
      Me.columnCDCodice = New Global.System.Data.DataColumn("CDCodice", GetType(Integer), Nothing, Global.System.Data.MappingType.Element)
      MyBase.Columns.Add(Me.columnCDCodice)
      Me.columnCDDescrizione = New Global.System.Data.DataColumn("CDDescrizione", GetType(String), Nothing, Global.System.Data.MappingType.Element)
      MyBase.Columns.Add(Me.columnCDDescrizione)
      Me.columnCDCodCau = New Global.System.Data.DataColumn("CDCodCau", GetType(String), Nothing, Global.System.Data.MappingType.Element)
      MyBase.Columns.Add(Me.columnCDCodCau)
      Me.columnCDFlgDisab = New Global.System.Data.DataColumn("CDFlgDisab", GetType(Integer), Nothing, Global.System.Data.MappingType.Element)
      MyBase.Columns.Add(Me.columnCDFlgDisab)
      Me.columnCDOper1 = New Global.System.Data.DataColumn("CDOper1", GetType(String), Nothing, Global.System.Data.MappingType.Element)
      MyBase.Columns.Add(Me.columnCDOper1)
      Me.columnCDOperatore = New Global.System.Data.DataColumn("CDOperatore", GetType(String), Nothing, Global.System.Data.MappingType.Element)
      MyBase.Columns.Add(Me.columnCDOperatore)
      Me.columnCDOper2Val = New Global.System.Data.DataColumn("CDOper2Val", GetType(String), Nothing, Global.System.Data.MappingType.Element)
      MyBase.Columns.Add(Me.columnCDOper2Val)
      Me.columnCDOper2Tipo = New Global.System.Data.DataColumn("CDOper2Tipo", GetType(Integer), Nothing, Global.System.Data.MappingType.Element)
      MyBase.Columns.Add(Me.columnCDOper2Tipo)
      Me.columnCDFlgBloc = New Global.System.Data.DataColumn("CDFlgBloc", GetType(Boolean), Nothing, Global.System.Data.MappingType.Element)
      MyBase.Columns.Add(Me.columnCDFlgBloc)
      Me.columnCDFlgOnlyEnd = New Global.System.Data.DataColumn("CDFlgOnlyEnd", GetType(Integer), Nothing, Global.System.Data.MappingType.Element)
      MyBase.Columns.Add(Me.columnCDFlgOnlyEnd)
      Me.columnCDMessaggio = New Global.System.Data.DataColumn("CDMessaggio", GetType(String), Nothing, Global.System.Data.MappingType.Element)
      MyBase.Columns.Add(Me.columnCDMessaggio)
      Me.columnCDCodCnn = New Global.System.Data.DataColumn("CDCodCnn", GetType(Byte), Nothing, Global.System.Data.MappingType.Element)
      MyBase.Columns.Add(Me.columnCDCodCnn)
      Me.columnCDOrdine = New Global.System.Data.DataColumn("CDOrdine", GetType(Integer), Nothing, Global.System.Data.MappingType.Element)
      MyBase.Columns.Add(Me.columnCDOrdine)

      Me.Constraints.Add(New Global.System.Data.UniqueConstraint("Constraint1", New Global.System.Data.DataColumn() {Me.columnCDCodice}, True))
      Me.columnCDCodice.AllowDBNull = False
      Me.columnCDCodCnn.DefaultValue = CType(0, Byte)
    End Sub

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>
    Public Function NewTabCtrlDocRow() As TabCtrlDocRow
      Return CType(Me.NewRow, TabCtrlDocRow)
    End Function

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>
    Protected Overrides Function NewRowFromBuilder(ByVal builder As Global.System.Data.DataRowBuilder) As Global.System.Data.DataRow
      Return New TabCtrlDocRow(builder)
    End Function

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>
    Protected Overrides Function GetRowType() As Global.System.Type
      Return GetType(TabCtrlDocRow)
    End Function

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>
    Protected Overrides Sub OnRowChanged(ByVal e As Global.System.Data.DataRowChangeEventArgs)
      MyBase.OnRowChanged(e)
      If (Not (Me.TabCtrlDocRowChangedEvent) Is Nothing) Then
        RaiseEvent TabCtrlDocRowChanged(Me, New TabCtrlDocRowChangeEvent(CType(e.Row, TabCtrlDocRow), e.Action))
      End If
    End Sub

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>
    Protected Overrides Sub OnRowChanging(ByVal e As Global.System.Data.DataRowChangeEventArgs)
      MyBase.OnRowChanging(e)
      If (Not (Me.TabCtrlDocRowChangingEvent) Is Nothing) Then
        RaiseEvent TabCtrlDocRowChanging(Me, New TabCtrlDocRowChangeEvent(CType(e.Row, TabCtrlDocRow), e.Action))
      End If
    End Sub

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>
    Protected Overrides Sub OnRowDeleted(ByVal e As Global.System.Data.DataRowChangeEventArgs)
      MyBase.OnRowDeleted(e)
      If (Not (Me.TabCtrlDocRowDeletedEvent) Is Nothing) Then
        RaiseEvent TabCtrlDocRowDeleted(Me, New TabCtrlDocRowChangeEvent(CType(e.Row, TabCtrlDocRow), e.Action))
      End If
    End Sub

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>
    Protected Overrides Sub OnRowDeleting(ByVal e As Global.System.Data.DataRowChangeEventArgs)
      MyBase.OnRowDeleting(e)
      If (Not (Me.TabCtrlDocRowDeletingEvent) Is Nothing) Then
        RaiseEvent TabCtrlDocRowDeleting(Me, New TabCtrlDocRowChangeEvent(CType(e.Row, TabCtrlDocRow), e.Action))
      End If
    End Sub

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>
    Public Sub RemoveTabCtrlDocRow(ByVal row As TabCtrlDocRow)
      Me.Rows.Remove(row)
    End Sub

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>
    Public Shared Function GetTypedTableSchema(ByVal xs As Global.System.Xml.Schema.XmlSchemaSet) As Global.System.Xml.Schema.XmlSchemaComplexType
      Dim type As Global.System.Xml.Schema.XmlSchemaComplexType = New Global.System.Xml.Schema.XmlSchemaComplexType
      Dim sequence As Global.System.Xml.Schema.XmlSchemaSequence = New Global.System.Xml.Schema.XmlSchemaSequence
      Dim ds As dstConfig = New dstConfig
      Dim any1 As Global.System.Xml.Schema.XmlSchemaAny = New Global.System.Xml.Schema.XmlSchemaAny
      any1.Namespace = "http://www.w3.org/2001/XMLSchema"
      any1.MinOccurs = New Decimal(0)
      any1.MaxOccurs = Decimal.MaxValue
      any1.ProcessContents = Global.System.Xml.Schema.XmlSchemaContentProcessing.Lax
      sequence.Items.Add(any1)
      Dim any2 As Global.System.Xml.Schema.XmlSchemaAny = New Global.System.Xml.Schema.XmlSchemaAny
      any2.Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1"
      any2.MinOccurs = New Decimal(1)
      any2.ProcessContents = Global.System.Xml.Schema.XmlSchemaContentProcessing.Lax
      sequence.Items.Add(any2)
      Dim attribute1 As Global.System.Xml.Schema.XmlSchemaAttribute = New Global.System.Xml.Schema.XmlSchemaAttribute
      attribute1.Name = "namespace"
      attribute1.FixedValue = ds.Namespace
      type.Attributes.Add(attribute1)
      Dim attribute2 As Global.System.Xml.Schema.XmlSchemaAttribute = New Global.System.Xml.Schema.XmlSchemaAttribute
      attribute2.Name = "tableTypeName"
      attribute2.FixedValue = "TabCtrlDocDataTable"
      type.Attributes.Add(attribute2)
      type.Particle = sequence
      Dim dsSchema As Global.System.Xml.Schema.XmlSchema = ds.GetSchemaSerializable
      If xs.Contains(dsSchema.TargetNamespace) Then
        Dim s1 As Global.System.IO.MemoryStream = New Global.System.IO.MemoryStream
        Dim s2 As Global.System.IO.MemoryStream = New Global.System.IO.MemoryStream
        Try
          Dim schema As Global.System.Xml.Schema.XmlSchema = Nothing
          dsSchema.Write(s1)
          Dim schemas As Global.System.Collections.IEnumerator = xs.Schemas(dsSchema.TargetNamespace).GetEnumerator
          Do While schemas.MoveNext
            schema = CType(schemas.Current, Global.System.Xml.Schema.XmlSchema)
            s2.SetLength(0)
            schema.Write(s2)
            If (s1.Length = s2.Length) Then
              s1.Position = 0
              s2.Position = 0

              Do While ((s1.Position <> s1.Length) _
                                        AndAlso (s1.ReadByte = s2.ReadByte))


              Loop
              If (s1.Position = s1.Length) Then
                Return type
              End If
            End If

          Loop
        Finally
          If (Not (s1) Is Nothing) Then
            s1.Close()
          End If
          If (Not (s2) Is Nothing) Then
            s2.Close()
          End If
        End Try
      End If
      xs.Add(dsSchema)
      Return type
    End Function

    ''' <summary>
    ''' funzione che da il via ai controlli scorrendo la tabella TabCtrlDoc, filtrando il campo 'CDOper1' per cqpire se la riga è quella che contiene il cotnrollo da eseguire in quel momento
    ''' </summary>
    ''' <param name="rowVWdoc">DataRow con i valori da controllare</param>
    ''' <param name="colConnectionStrings">Elenco delle connessioni disponibili</param>
    ''' <param name="strFiltro">campo di filtro per selezionare i controlli</param>
    ''' <param name="strCausale">nome del campo contenente il codice causale</param>
    ''' <param name="blnNotOnlyEnd"> se è true il controllo va effettuato solo al salvataggio del record </param>
    ''' <returns></returns>
    Public Function fncStartCtrl(ByVal rowVWdoc As DataRow,
                                 ByRef colDecodCtrl As ValuesControlCollection,
                                 ByVal colConnectionStrings As Dictionary(Of Integer, String),
                                 ByVal strFiltro As String,
                                 ByVal strCausale As String,
                                 ByRef strQryLog As String,
                                 ByRef strErrCtrl As String,
                                 ByVal intOnlyEnd As Integer) As clsCtrlRisultato
      'Optional ByVal blnNotOnlyEnd As Boolean = False) As clsCtrlRisultato

      Dim adapterCtrl As dstConfigTableAdapters.tbaTabCtrlDoc
      Dim tabCtrl As New TabCtrlDocDataTable
      Dim rowCtrl As TabCtrlDocRow
      Dim blnRisCtrl As Boolean = True
      Dim strCodCau As String
      Dim dllDB As New GsLibCeDB.GsDBADO
      Dim Risultato As New clsCtrlRisultato
      Dim DiffTotPeso As Decimal

      strQryLog = String.Empty
      strErrCtrl = String.Empty
      blnRisCtrl = True
      adapterCtrl = New dstConfigTableAdapters.tbaTabCtrlDoc
      Risultato.NomeCampo = String.Empty
      Risultato.Risultato = True
      DiffTotPeso = 0

      'apro connessione per caricare i dati

      'leggo la Causale 
      strCodCau = Convert.ToString(dllDB.NullFldObj(rowVWdoc, strCausale, ""))

      adapterCtrl.Connection = dllG3Bce.SQLGes.MakeNewCnn(colConnectionStrings(0))

      'carica i controlli da effetture 
      If strFiltro = String.Empty Then
        'carico tutti i controlli
        adapterCtrl.FillSave(tabCtrl, strCodCau)
      Else
        'carico i controlli sul campo indicato
        adapterCtrl.Fill(tabCtrl, strCodCau, strFiltro)
      End If

      'recupera il riferimento DEI CONTROLLI
      For Each rowCtrl In tabCtrl

        rowCtrl.QryCtrlText = String.Empty

        'controllo se devo eseguire ora il controllo o alla fine
        '(blnUltimaRiga = False And rowCtrl.CDFlgOnlyEnd = 2)
        If (intOnlyEnd <> 1 And rowCtrl.CDFlgOnlyEnd = 1) Or (rowCtrl.CDFlgOnlyEnd = 2 And intOnlyEnd <> 2) Or (rowCtrl.CDFlgOnlyEnd = 0 And intOnlyEnd = 2) Then

          'il controllo va effettuato alla fine e dovrò ricevere gestOnlyEnd=true
          blnRisCtrl = True
          Risultato.Risultato = True
          Risultato.NomeCampo = String.Empty

        Else 'gestOnlyEnd = True And rowCtrl.CDFlgOnlyEnd = 1

          'è il controllo che devo effettuare, quindi lo svolgo
          blnRisCtrl = rowCtrl.fncControlli(rowVWdoc, colDecodCtrl, colConnectionStrings)

          ' restituisce info su errori
          strErrCtrl = strErrCtrl & " " & rowCtrl.CDDescrizione & " " & rowCtrl.ExceptionText & "--"
          ' restituisce info su comandi eseguiti
          strQryLog = strQryLog & rowCtrl.QryCtrlText & " GO "

          ' se il primo controllo bloccante fallisce esce dal ciclo
          If Not blnRisCtrl Then
            Risultato.Risultato = False
            Risultato.NomeCampo = rowCtrl.CDOper1
            Return Risultato
          End If

        End If 'gestOnlyEnd = True And rowCtrl.CDFlgOnlyEnd = 1

      Next

      Return Risultato

    End Function 'fncStartCtrl


    ''' <summary>
    ''' Classe contentente l'oggetto utilizzato per la gestione del risultato dei cotnrolli
    ''' </summary>
    Public Class clsCtrlRisultato

      Private strNomeCampo As Global.System.String
      Private blnRisultato As Global.System.Boolean

      Public Property NomeCampo() As String
        Get
          Return Me.strNomeCampo
        End Get

        Set(value As String)
          Me.strNomeCampo = value
        End Set

      End Property

      Public Property Risultato() As Boolean
        Get
          Return Me.blnRisultato
        End Get

        Set(value As Boolean)
          Me.blnRisultato = value
        End Set

      End Property

    End Class

  End Class

  '___________________________________________________________________________________________________________________________________________________
  Partial Public Class TabCtrlDocRow
    Inherits Global.System.Data.DataRow

    Private tableTabCtrlDoc As TabCtrlDocDataTable

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>
    Friend Sub New(ByVal rb As Global.System.Data.DataRowBuilder)
      MyBase.New(rb)
      Me.tableTabCtrlDoc = CType(Me.Table, TabCtrlDocDataTable)
    End Sub

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>
    Public Property CDCodice() As Integer
      Get
        Return CType(Me(Me.tableTabCtrlDoc.CDCodiceColumn), Integer)
      End Get
      Set
        Me(Me.tableTabCtrlDoc.CDCodiceColumn) = Value
      End Set
    End Property

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>
    Public Property CDDescrizione() As String
      Get
        Return CType(Me(Me.tableTabCtrlDoc.CDDescrizioneColumn), String)
      End Get
      Set
        Me(Me.tableTabCtrlDoc.CDDescrizioneColumn) = Value
      End Set
    End Property

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>
    Public Property CDCodCau() As String
      Get
        Try
          Return CType(Me(Me.tableTabCtrlDoc.CDCodCauColumn), String)
        Catch e As Global.System.InvalidCastException
          Throw New Global.System.Data.StrongTypingException("The value for column 'CDCodCau' in table 'TabCtrlDoc' is DBNull.", e)
        End Try
      End Get
      Set
        Me(Me.tableTabCtrlDoc.CDCodCauColumn) = Value
      End Set
    End Property

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>
    Public Property CDFlgDisab() As Integer
      Get
        Try
          Return CType(Me(Me.tableTabCtrlDoc.CDFlgDisabColumn), Integer)
        Catch e As Global.System.InvalidCastException
          Throw New Global.System.Data.StrongTypingException("The value for column 'CDFlagDisab' in table 'TabCtrlDoc' is DBNull.", e)
        End Try
      End Get
      Set
        Me(Me.tableTabCtrlDoc.CDFlgDisabColumn) = Value
      End Set
    End Property

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>
    Public Property CDOper1() As String
      Get
        Try
          Return CType(Me(Me.tableTabCtrlDoc.CDOper1Column), String)
        Catch e As Global.System.InvalidCastException
          Throw New Global.System.Data.StrongTypingException("The value for column 'CDOper1' in table 'TabCtrlDoc' is DBNull.", e)
        End Try
      End Get
      Set
        Me(Me.tableTabCtrlDoc.CDOper1Column) = Value
      End Set
    End Property

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>
    Public Property CDOperatore() As String
      Get
        If Me.IsCDOperatoreNull Then
          Return String.Empty
        Else
          Return CType(Me(Me.tableTabCtrlDoc.CDOperatoreColumn), String)
        End If
      End Get
      Set
        Me(Me.tableTabCtrlDoc.CDOperatoreColumn) = Value
      End Set
    End Property

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>
    Public Property CDOper2Val() As String
      Get
        Try
          Return CType(Me(Me.tableTabCtrlDoc.CDOper2ValColumn), String)
        Catch e As Global.System.InvalidCastException
          Throw New Global.System.Data.StrongTypingException("The value for column 'CDOper2Val' in table 'TabCtrlDoc' is DBNull.", e)
        End Try
      End Get
      Set
        Me(Me.tableTabCtrlDoc.CDOper2ValColumn) = Value
      End Set
    End Property

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>
    Public Property CDOper2Tipo() As Integer
      Get
        Try
          Return CType(Me(Me.tableTabCtrlDoc.CDOper2TipoColumn), Integer)
        Catch e As Global.System.InvalidCastException
          Throw New Global.System.Data.StrongTypingException("The value for column 'CDOper2Tipo' in table 'TabCtrlDoc' is DBNull.", e)
        End Try
      End Get
      Set
        Me(Me.tableTabCtrlDoc.CDOper2TipoColumn) = Value
      End Set
    End Property

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>
    Public Property CDFlgBloc() As Boolean
      Get
        Try
          Return CType(Me(Me.tableTabCtrlDoc.CDFlgBlocColumn), Boolean)
        Catch e As Global.System.InvalidCastException
          Throw New Global.System.Data.StrongTypingException("The value for column 'CDFlgBloc' in table 'TabCtrlDoc' is DBNull.", e)
        End Try
      End Get
      Set
        Me(Me.tableTabCtrlDoc.CDFlgBlocColumn) = Value
      End Set
    End Property

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>
    Public Property CDFlgOnlyEnd() As Integer
      Get
        Try
          Return CType(Me(Me.tableTabCtrlDoc.CDFlgOnlyEndColumn), Integer)
        Catch e As Global.System.InvalidCastException
          Throw New Global.System.Data.StrongTypingException("The value for column 'CDFlgOnlyEnd' in table 'TabCtrlDoc' is DBNull.", e)
        End Try
      End Get
      Set
        Me(Me.tableTabCtrlDoc.CDFlgOnlyEndColumn) = Value
      End Set
    End Property

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>
    Public Property CDMessaggio() As String
      Get
        Try
          Return CType(Me(Me.tableTabCtrlDoc.CDMessaggioColumn), String)
        Catch e As Global.System.InvalidCastException
          Throw New Global.System.Data.StrongTypingException("The value for column 'CDMessaggio' in table 'TabCtrlDoc' is DBNull.", e)
        End Try
      End Get
      Set
        Me(Me.tableTabCtrlDoc.CDMessaggioColumn) = Value
      End Set
    End Property

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>
    Public Property CDCodCnn() As Byte
      Get
        Try
          Return CType(Me(Me.tableTabCtrlDoc.CDCodCnnColumn), Byte)
        Catch e As Global.System.InvalidCastException
          Throw New Global.System.Data.StrongTypingException("The value for column 'CDCodCnn' in table 'TabCampi' is DBNull.", e)
        End Try
      End Get
      Set
        Me(Me.tableTabCtrlDoc.CDCodCnnColumn) = Value
      End Set
    End Property


    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>
    Public Property CDOrdine() As Integer
      Get
        Try
          Return CType(Me(Me.tableTabCtrlDoc.CDOrdineColumn), Integer)
        Catch e As Global.System.InvalidCastException
          Throw New Global.System.Data.StrongTypingException("The value for column 'CDOrdine' in table 'TabCampi' is DBNull.", e)
        End Try
      End Get
      Set
        Me(Me.tableTabCtrlDoc.CDOrdineColumn) = Value
      End Set
    End Property


    ''' <summary>Testo in formato SQL del controllo</summary>
    ''' <returns></returns>
    ''' 
    Private strQryCtrl As Global.System.String
    Public Property QryCtrlText() As String
      Get
        Return Me.strQryCtrl
      End Get
      Set(value As String)
        Me.strQryCtrl = value
      End Set
    End Property

    ''' <summary>Testo dell'eccezione generata dall'esecuzione del controllo</summary>
    ''' <returns></returns>
    ''' 
    Private strExceptionText As Global.System.String
    Public Property ExceptionText() As String
      Get
        Return Me.strExceptionText
      End Get
      Set(value As String)
        Me.strExceptionText = value
      End Set
    End Property



    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>
    Public Function IsCDCodiceNull() As Boolean
      Return Me.IsNull(Me.tableTabCtrlDoc.CDCodiceColumn)
    End Function


    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>
    Public Function IsCDDescrizioneNull() As Boolean
      Return Me.IsNull(Me.tableTabCtrlDoc.CDDescrizioneColumn)
    End Function

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>
    Public Sub SetCDDescrizioneNull()
      Me(Me.tableTabCtrlDoc.CDDescrizioneColumn) = Global.System.Convert.DBNull
    End Sub

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>
    Public Function IsCDFlgDisabNull() As Integer
      Return Me.IsNull(Me.tableTabCtrlDoc.CDFlgDisabColumn)
    End Function

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>
    Public Sub SetCDFlgDisabNull()
      Me(Me.tableTabCtrlDoc.CDFlgDisabColumn) = Global.System.Convert.DBNull
    End Sub

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>
    Public Function IsCDOper1Null() As Boolean
      Return Me.IsNull(Me.tableTabCtrlDoc.CDOper1Column)
    End Function

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>
    Public Sub SetCDOper1Null()
      Me(Me.tableTabCtrlDoc.CDOper1Column) = Global.System.Convert.DBNull
    End Sub

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>
    Public Function IsCDOperatoreNull() As Boolean
      Return Me.IsNull(Me.tableTabCtrlDoc.CDOperatoreColumn)
    End Function

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>
    Public Sub SetCDOperatoreNull()
      Me(Me.tableTabCtrlDoc.CDOperatoreColumn) = Global.System.Convert.DBNull
    End Sub

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>
    Public Function IsCDCodCauNull() As Boolean
      Return Me.IsNull(Me.tableTabCtrlDoc.CDCodCauColumn)
    End Function

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>
    Public Sub SetCDCodCauNull()
      Me(Me.tableTabCtrlDoc.CDCodCauColumn) = Global.System.Convert.DBNull
    End Sub

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>
    Public Function IsCDOper2ValNull() As Boolean
      Return Me.IsNull(Me.tableTabCtrlDoc.CDOper2ValColumn)
    End Function

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>
    Public Sub SetCDOper2ValNull()
      Me(Me.tableTabCtrlDoc.CDOper2ValColumn) = Global.System.Convert.DBNull
    End Sub

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>
    Public Function IsCDOper2TipoNull() As Boolean
      Return Me.IsNull(Me.tableTabCtrlDoc.CDOper2TipoColumn)
    End Function

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>
    Public Sub SetCDOper2TipoNull()
      Me(Me.tableTabCtrlDoc.CDOper2TipoColumn) = Global.System.Convert.DBNull
    End Sub

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>
    Public Function IsCDFlgBlocNull() As Boolean
      Return Me.IsNull(Me.tableTabCtrlDoc.CDFlgBlocColumn)
    End Function

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>
    Public Sub SetCDFlgBlocNull()
      Me(Me.tableTabCtrlDoc.CDFlgBlocColumn) = Global.System.Convert.DBNull
    End Sub

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>
    Public Function IsCDFlgOnlyEndNull() As Integer
      Return Me.IsNull(Me.tableTabCtrlDoc.CDFlgOnlyEndColumn)
    End Function

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>
    Public Sub SetCDMessaggioNull()
      Me(Me.tableTabCtrlDoc.CDMessaggioColumn) = Global.System.Convert.DBNull
    End Sub


    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>
    Public Function IsCDCodCnnNull() As Boolean
      Return Me.IsNull(Me.tableTabCtrlDoc.CDCodCnnColumn)
    End Function

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>
    Public Sub SetCDCodCnnNullCodCnnNull()
      Me(Me.tableTabCtrlDoc.CDCodCnnColumn) = Global.System.Convert.DBNull
    End Sub


    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>
    Public Function IsCDOrdineNull() As Boolean
      Return Me.IsNull(Me.tableTabCtrlDoc.CDOrdineColumn)
    End Function

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>
    Public Sub SetCDOrdineNullCodCnnNull()
      Me(Me.tableTabCtrlDoc.CDOrdineColumn) = Global.System.Convert.DBNull
    End Sub

    ''' <summary>
    ''' Funzione che inizia a effettuare il contrllo selezionato precedentemente, caricando i dati 
    ''' </summary>
    ''' <param name="vwDocrow">riga dei dati presenti nel form</param>
    ''' <param name="cnn">tipo di connessione</param>
    ''' <param name="fOper1">filtro su operatore 1</param>
    ''' <param name="ctrlMsg"> True visualizzo il messaggio dato dal controllo altrimenti no</param>
    ''' <returns></returns>
    Public Function fncControlli(ByVal vwDocrow As DataRow,
                                   ByRef colDecodCtrl As ValuesControlCollection,
                                   ByVal colConnectionStrings As Dictionary(Of Integer, String)) As Boolean

      Dim strMessaggio As String
      Dim blnRisultato As Boolean
      Dim dllDB As New GsLibCeDB.GsDBADO
      'Dim raccDecodCtrl As ValuesControlCollection
      'creo una raccolta di (come si chiama esattamente?)
      'raccDecodCtrl = vwDocrow.fncAddRaccCtrl()

      'eseguo il controllo
      blnRisultato = Me.fncEseguiControllo(vwDocrow, colDecodCtrl, colConnectionStrings)

      If (blnRisultato = True) Then

        'controllo andato a buon fine
        System.Diagnostics.Debug.WriteLine(" fncControlli : controllo andato a buon fine")
        Return True

      Else

        'faccio visualizzare il messaggio contenuto nella riga
        strMessaggio = Me.CDMessaggio
        'decodifico i valori presenti nel messaggio
        'utilizzo la Funzione ReplaceAllTags per sostituire "@Nome" col suo valore all'interno della stringa
        strMessaggio = colDecodCtrl.ReplaceAllTags(strMessaggio)


        'controllo l'esito del controllo, se è false e il controllo è bloccante blocco l'esecuzione
        If Me.CDFlgBloc = True Then

          'stampo la messagboxx
          Messages.MessageInfo.Show(strMessaggio)
        Else
          ' aggiunge domanda all'utente per consentire di avanzare comunque
          strMessaggio &= vbCrLf & "Continuare?"
          ' richiesta all'utente
          If Messages.MessageInfo.ShowQuestion(strMessaggio, Windows.Forms.MessageBoxDefaultButton.Button2) = vbYes Then

            ' consente all'esecuzione di proseguire
            Return True
          End If

        End If

        ' blocca l'esecuzione
        Return False
      End If '(risultato = True)

    End Function 'Controlli


    ''' <summary>
    ''' Funzione per eseguire la valutazione di un controllo
    ''' </summary>
    ''' <param name="rowRecordDaControllare">Insieme die valori da controllare</param>
    ''' <returns>Restituisce true per indicare che il controllo è andato a buon fine, false indica che il controllo ha degli errori</returns>
    Public Function fncEseguiControllo(ByVal vwDocRow As DataRow, ByRef colDecodCtrl As Utility.ValuesControlCollection, ByVal colConnectionStrings As Dictionary(Of Integer, String)) As Boolean

      Dim strSQL As String
      Dim objVal1 As Object
      Dim strVal2 As String
      Dim strOperatore As String
      Dim strOperando2Val As String
      Dim strOperando2Tipo As String
      Dim dllDB As New GsLibCeDB.GsDBADO
      Dim cnnDB As Integer
      Dim risultato As Integer
      Dim objRisultato As Object
      Dim strOperando1 As String
      Dim arrPram(8) As String
      Dim decQtaPrelCalc As Decimal = 0
      Dim strCompare As String = String.Empty


      Try

        'recupero il valore dell'operando di riferimento controllando se è null
        strOperando1 = dllDB.NullFldObj(Me, "CDOper1", "")

        strCompare = vwDocRow.Table.Columns.Item(strOperando1).DataType.ToString

        'strComparer = objVal1DataType.FullName.ToString

        Select Case strCompare

          Case "System.Decimal"
            'se il campo in riga è DBNULL inserisco 0 nell'oggetto
            objVal1 = dllDB.NullFldObj(vwDocRow, strOperando1, 0)
            'controllo se il campo è vuoto
            If objVal1 = 0 Then
              strCompare = String.Empty
            End If
            'inserisco il valore trovato nella raccolta
            colDecodCtrl.Item("Operando1").Value = dllDB.SQLNumeric(objVal1)

          Case "System.DateTime"
            'se il campo in riga è DBNULL inserisco 01/01/0001 nell'oggetto
            objVal1 = dllDB.NullFldObj(vwDocRow, strOperando1, Date.MinValue)
            'controllo se il campo è vuoto
            If objVal1 = Date.MinValue Then
              strCompare = String.Empty
            End If
            'inserisco il valore trovato nella raccolta
            colDecodCtrl.Item("Operando1").Value = dllDB.SQLDate(objVal1)

          Case "System.Boolean"
            'se il campo in riga è DBNULL inserisco False nell'oggetto
            objVal1 = dllDB.NullFldObj(vwDocRow, strOperando1, False)
            'controllo se il campo è vuoto
            If objVal1 = False Then
              strCompare = String.Empty
            End If
            'inserisco il valore trovato nella raccolta
            colDecodCtrl.Item("Operando1").Value = dllDB.SQLBoolean(objVal1)

          Case Else
            'se il campo in riga è DBNULL inserisco empty nell'oggetto
            objVal1 = dllDB.NullFldObj(vwDocRow, strOperando1, String.Empty)
            'controllo se il campo è vuoto
            If objVal1.ToString() = String.Empty Then
              strCompare = String.Empty
            End If
            'inserisco il valore trovato nella raccolta
            colDecodCtrl.Item("Operando1").Value = dllDB.SQLString(objVal1)

        End Select


        'Controllo sul bloccante se valorizzato
        'strCompare è vuoto significa che il valore della riga era DBNULL
        If (dllDB.NullFldInt(Me, "CDFlgDisab") = 1) And (strCompare = String.Empty) Then
          'restituisco true perchè il controllo non va effettuato
          Return True
        End If

        'recupero tipo e valore dell'operando 2 e opertore in modo da valutarli nella fncGetValore2()
        strOperatore = dllDB.NullFldObj(Me, "CDOperatore", "")
        strOperando2Val = dllDB.NullFldObj(Me, "CDOper2Val", "")
        strOperando2Tipo = dllDB.NullFldObj(Me, "CDOper2Tipo", "")

        'recupero il codice della connessione da utilizare
        cnnDB = dllDB.NullFldInt(Me, "CDCodCnn")
        'funzione gestisce l operatore 2 e lo restituisce pronto per esser utilizzato
        'se è Func i tag verranno cambiati in face di creazione della query
        'se è tag è già pronto per l'utilizzo
        strVal2 = fncGetValore2(strOperando2Val, colDecodCtrl)
        'genero la query
        strSQL = fncCreaQry(Convert.ToString(colDecodCtrl.Item("Operando1").Value), strVal2, strOperatore, colDecodCtrl)

        'la Qry viene scritta in tabella per sriverla nel log 
        Me.QryCtrlText = strSQL
        Me.ExceptionText = String.Empty

        If strSQL <> String.Empty Then

          Try
            'eseguo la query
            objRisultato = SQLGes.fncExecQry(strSQL, cnnDB, colConnectionStrings)

            risultato = Convert.ToInt32(objRisultato)

          Catch ex As Exception
            risultato = 0
            'Messaggio di errore generato dall'esecuzione del controllo
            Me.ExceptionText = Messages.MessageErr.GetText("fncExecQry()", ex)

          End Try

        Else

          System.Diagnostics.Debug.WriteLine(" fncEseguiControllo : la stringa contenente la qry è VUOTA")
          risultato = 0

        End If

        'eseguo il controllo sul risultato
        If (risultato = 1) Then
          System.Diagnostics.Debug.WriteLine(" fncEseguiControllo : Risultato CTRL corretto")
          Return True
        Else
          System.Diagnostics.Debug.WriteLine(" fncEseguiControllo : Risultato CTRL NON corretto")
          Return False
        End If

      Catch ex As Exception
        Me.ExceptionText = Messages.MessageErr.GetText("fncEseguiControllo()", ex)
        Return False
      End Try

    End Function



    ''' <summary>
    ''' Funzione che riceve il tipo e il valore di operando ed in base ad essi trova il valore corretto da restituire
    ''' </summary>
    ''' <param name="strOp2Val">valore dell'operando 2 da valutare</param>
    ''' <param name="strOp2Tipo">tipo dell'operando</param>
    ''' <returns>ritorna il valore dell'operando 2 pronto per esser inserito nella query</returns>
    Private Function fncGetValore2(ByVal strOp2Val As String, ByVal raccDecodCtrl As Utility.ValuesControlCollection) As Object

      Dim strVal2 As String

      'utilizzo la Funzione ReplaceAllTags per sostituire "@Nome" col suo valore all'interno della stringa
      strVal2 = raccDecodCtrl.ReplaceAllTags(strOp2Val)

      Return strVal2

    End Function

    ''' <summary>
    ''' Funzione che restituisce la query formattata per la verifica finale del controllo
    ''' </summary>
    ''' <param name="Valore1">Valore da controllare</param>
    ''' <param name="Valore2">Valore di riferimento</param>
    ''' <param name="Operatore">Operatore da utilizzare nel controllo</param>
    ''' <returns></returns>
    Private Function fncCreaQry(ByVal Valore1 As String,
                                ByVal Valore2 As String,
                                ByVal Operatore As String,
                                ByRef raccDecodCtrl As Utility.ValuesControlCollection) As String

      Dim strQry As String
      Dim strWQry As String
      Dim dllDB As New GsLibCeDB.GsDBADO


      'genero la query
      strWQry = "SELECT 1 WHERE " & Valore1 & " " & Operatore & " " & Valore2

      System.Diagnostics.Debug.WriteLine(" fncCreaQry : " + strWQry)

      'eseguo la sostituzione dei tag
      strQry = raccDecodCtrl.ReplaceAllTags(strWQry)

      'restituisco query
      Return strQry

    End Function 'fncCreaQry



  End Class

  '________________________________________________________________________________________________________________________________________
  '''<summary>
  '''Row event argument class
  '''</summary>
  Public Class TabCtrlDocRowChangeEvent
    Inherits Global.System.EventArgs

    Private eventRow As TabCtrlDocRow

    Private eventAction As Global.System.Data.DataRowAction

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>
    Public Sub New(ByVal row As TabCtrlDocRow, ByVal action As Global.System.Data.DataRowAction)
      MyBase.New
      Me.eventRow = row
      Me.eventAction = action
    End Sub

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>
    Public ReadOnly Property Row() As TabCtrlDocRow
      Get
        Return Me.eventRow
      End Get
    End Property

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>
    Public ReadOnly Property Action() As Global.System.Data.DataRowAction
      Get
        Return Me.eventAction
      End Get
    End Property
  End Class
End Class
