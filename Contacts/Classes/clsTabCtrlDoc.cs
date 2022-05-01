using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.IO;
using dllG3Bce;
using dllG3Bce.dstDocum;
using dllG3Bce.dstDocumTableAdapters;
using dllG3Bce.Utility;
using Microsoft.VisualBasic; // Install-Package Microsoft.VisualBasic
using Microsoft.VisualBasic.CompilerServices; // Install-Package Microsoft.VisualBasic

public partial class dstConfig
{

    public delegate void TabCtrlDocRowChangeEventHandler(object sender, TabCtrlDocRowChangeEvent e);

    // _______________________________________________________________________________________________________________________________________________

    [System.Xml.Serialization.XmlSchemaProvider("GetTypedTableSchema")]
    public partial class TabCtrlDocDataTable : DataTable, IEnumerable
    {

        private DataColumn columnCDCodice;

        private DataColumn columnCDDescrizione;

        private DataColumn columnCDCodCau;

        private DataColumn columnCDFlgDisab;

        private DataColumn columnCDOper1;

        private DataColumn columnCDOperatore;

        private DataColumn columnCDOper2Val;

        private DataColumn columnCDOper2Tipo;

        private DataColumn columnCDFlgBloc;

        private DataColumn columnCDFlgOnlyEnd;

        private DataColumn columnCDMessaggio;

        private DataColumn columnCDCodCnn;

        private DataColumn columnCDOrdine;





        [DebuggerNonUserCode()]
        public TabCtrlDocDataTable() : base()
        {
            TableName = "TabCtrlDoc";
            BeginInit();
            InitClass();
            EndInit();
        }

        [DebuggerNonUserCode()]
        internal TabCtrlDocDataTable(DataTable table) : base()
        {
            TableName = table.TableName;
            if (table.CaseSensitive != table.DataSet.CaseSensitive)
            {
                CaseSensitive = table.CaseSensitive;
            }
            if ((table.Locale.ToString() ?? "") != (table.DataSet.Locale.ToString() ?? ""))
            {
                Locale = table.Locale;
            }
            if ((table.Namespace ?? "") != (table.DataSet.Namespace ?? ""))
            {
                Namespace = table.Namespace;
            }
            Prefix = table.Prefix;
            MinimumCapacity = table.MinimumCapacity;
        }

        [DebuggerNonUserCode()]
        public DataColumn CDCodiceColumn
        {
            get
            {
                return columnCDCodice;
            }
        }

        [DebuggerNonUserCode()]
        public DataColumn CDDescrizioneColumn
        {
            get
            {
                return columnCDDescrizione;
            }
        }

        [DebuggerNonUserCode()]
        public DataColumn CDCodCauColumn
        {
            get
            {
                return columnCDCodCau;
            }
        }

        [DebuggerNonUserCode()]
        public DataColumn CDFlgDisabColumn
        {
            get
            {
                return columnCDFlgDisab;
            }
        }

        [DebuggerNonUserCode()]
        public DataColumn CDOper1Column
        {
            get
            {
                return columnCDOper1;
            }
        }

        [DebuggerNonUserCode()]
        public DataColumn CDOperatoreColumn
        {
            get
            {
                return columnCDOperatore;
            }
        }

        [DebuggerNonUserCode()]
        public DataColumn CDOper2ValColumn
        {
            get
            {
                return columnCDOper2Val;
            }
        }

        [DebuggerNonUserCode()]
        public DataColumn CDOper2TipoColumn
        {
            get
            {
                return columnCDOper2Tipo;
            }
        }

        [DebuggerNonUserCode()]
        public DataColumn CDFlgBlocColumn
        {
            get
            {
                return columnCDFlgBloc;
            }
        }

        [DebuggerNonUserCode()]
        public DataColumn CDFlgOnlyEndColumn
        {
            get
            {
                return columnCDFlgOnlyEnd;
            }
        }

        [DebuggerNonUserCode()]
        public DataColumn CDMessaggioColumn
        {
            get
            {
                return columnCDMessaggio;
            }
        }

        [DebuggerNonUserCode()]
        public DataColumn CDCodCnnColumn
        {
            get
            {
                return columnCDCodCnn;
            }
        }

        [DebuggerNonUserCode()]
        public DataColumn CDOrdineColumn
        {
            get
            {
                return columnCDOrdine;
            }
        }

        [DebuggerNonUserCode()]
        public int Count
        {
            get
            {
                return Rows.Count;
            }
        }

        [DebuggerNonUserCode()]
        public TabCtrlDocRow this[int index]
        {
            get
            {
                return (TabCtrlDocRow)Rows[index];
            }
        }

        public event TabCtrlDocRowChangeEventHandler TabCtrlDocRowChanging;

        public event TabCtrlDocRowChangeEventHandler TabCtrlDocRowChanged;

        public event TabCtrlDocRowChangeEventHandler TabCtrlDocRowDeleting;

        public event TabCtrlDocRowChangeEventHandler TabCtrlDocRowDeleted;

        [DebuggerNonUserCode()]
        public void AddTabCtrlDocRow(TabCtrlDocRow row)
        {
            Rows.Add(row);
        }

        [DebuggerNonUserCode()]
        public TabCtrlDocRow AddTabCtrlDocRow(int CDCodice, string CdDescrizione, string CdCodCau, int CDFlgDisab, string CDOper1, string CDOperatore, string CDOper2Val, int CDOper2Tipo, bool CDFlgBloc, int CDFlgOnlyEnd, string CDMessaggio, byte CDCodCnn, int CDOrdine, string CDStrQry)
        {
            TabCtrlDocRow rowTabCtrlDocRow = (TabCtrlDocRow)NewRow();
            var columnValuesArray = new object[] { CDCodice, CdDescrizione, CdCodCau, CDFlgDisab, CDOper1, CDOperatore, CDOper2Val, CDOper2Tipo, CDFlgBloc, CDFlgOnlyEnd, CDMessaggio, CDCodCnn, CDOrdine, CDStrQry };
            rowTabCtrlDocRow.ItemArray = columnValuesArray;
            Rows.Add(rowTabCtrlDocRow);
            return rowTabCtrlDocRow;
        }

        [DebuggerNonUserCode()]
        public virtual IEnumerator GetEnumerator()
        {
            return Rows.GetEnumerator();
        }

        [DebuggerNonUserCode()]
        public override DataTable Clone()
        {
            TabCtrlDocDataTable cln = (TabCtrlDocDataTable)base.Clone();
            cln.InitVars();
            return cln;
        }

        [DebuggerNonUserCode()]
        protected override DataTable CreateInstance()
        {
            return new TabCtrlDocDataTable();
        }

        [DebuggerNonUserCode()]
        internal void InitVars()
        {
            columnCDCodice = Columns["CDCodice"];
            columnCDDescrizione = Columns["CDDescrizione"];
            columnCDCodCau = Columns["CDCodCau"];
            columnCDFlgDisab = Columns["CDFlgDisab"];
            columnCDOper1 = Columns["CDOper1"];
            columnCDOperatore = Columns["CDOperatore"];
            columnCDOper2Val = Columns["CDOper2Val"];
            columnCDOper2Tipo = Columns["CDOper2Tipo"];
            columnCDFlgBloc = Columns["CDFlgBloc"];
            columnCDFlgOnlyEnd = Columns["CDFlgOnlyEnd"];
            columnCDMessaggio = Columns["CDMessaggio"];
            columnCDCodCnn = Columns["CDCodCnn"];
            columnCDOrdine = Columns["CDOrdine"];
        }

        [DebuggerNonUserCode()]
        private void InitClass()
        {
            columnCDCodice = new DataColumn("CDCodice", typeof(int), null, MappingType.Element);
            Columns.Add(columnCDCodice);

            columnCDDescrizione = new DataColumn("CDDescrizione", typeof(string), null, MappingType.Element);
            Columns.Add(columnCDDescrizione);

            columnCDCodCau = new DataColumn("CDCodCau", typeof(string), null, MappingType.Element);
            Columns.Add(columnCDCodCau);

            columnCDFlgDisab = new DataColumn("CDFlgDisab", typeof(int), null, MappingType.Element);
            Columns.Add(columnCDFlgDisab);

            columnCDOper1 = new DataColumn("CDOper1", typeof(string), null, MappingType.Element);
            Columns.Add(columnCDOper1);

            columnCDOperatore = new DataColumn("CDOperatore", typeof(string), null, MappingType.Element);
            Columns.Add(columnCDOperatore);

            columnCDOper2Val = new DataColumn("CDOper2Val", typeof(string), null, MappingType.Element);
            Columns.Add(columnCDOper2Val);

            columnCDOper2Tipo = new DataColumn("CDOper2Tipo", typeof(int), null, MappingType.Element);
            Columns.Add(columnCDOper2Tipo);

            columnCDFlgBloc = new DataColumn("CDFlgBloc", typeof(bool), null, MappingType.Element);
            Columns.Add(columnCDFlgBloc);

            columnCDFlgOnlyEnd = new DataColumn("CDFlgOnlyEnd", typeof(int), null, MappingType.Element);
            Columns.Add(columnCDFlgOnlyEnd);

            columnCDMessaggio = new DataColumn("CDMessaggio", typeof(string), null, MappingType.Element);
            Columns.Add(columnCDMessaggio);

            columnCDCodCnn = new DataColumn("CDCodCnn", typeof(byte), null, MappingType.Element);
            Columns.Add(columnCDCodCnn);

            columnCDOrdine = new DataColumn("CDOrdine", typeof(int), null, MappingType.Element);
            Columns.Add(columnCDOrdine);


            Constraints.Add(new UniqueConstraint("Constraint1", new DataColumn[] { columnCDCodice }, true));
            columnCDCodice.AllowDBNull = false;
            columnCDCodCnn.DefaultValue = 0;
        }

        [DebuggerNonUserCode()]
        public TabCtrlDocRow NewTabCtrlDocRow()
        {
            return (TabCtrlDocRow)NewRow();
        }

        [DebuggerNonUserCode()]
        protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
        {
            return new TabCtrlDocRow(builder);
        }

        [DebuggerNonUserCode()]
        protected override Type GetRowType()
        {
            return typeof(TabCtrlDocRow);
        }

        [DebuggerNonUserCode()]
        protected override void OnRowChanged(DataRowChangeEventArgs e)
        {
            base.OnRowChanged(e);
            if (TabCtrlDocRowChanged is not null)
            {
                TabCtrlDocRowChanged?.Invoke(this, new TabCtrlDocRowChangeEvent((TabCtrlDocRow)e.Row, e.Action));
            }
        }

        [DebuggerNonUserCode()]
        protected override void OnRowChanging(DataRowChangeEventArgs e)
        {
            base.OnRowChanging(e);
            if (TabCtrlDocRowChanging is not null)
            {
                TabCtrlDocRowChanging?.Invoke(this, new TabCtrlDocRowChangeEvent((TabCtrlDocRow)e.Row, e.Action));
            }
        }

        [DebuggerNonUserCode()]
        protected override void OnRowDeleted(DataRowChangeEventArgs e)
        {
            base.OnRowDeleted(e);
            if (TabCtrlDocRowDeleted is not null)
            {
                TabCtrlDocRowDeleted?.Invoke(this, new TabCtrlDocRowChangeEvent((TabCtrlDocRow)e.Row, e.Action));
            }
        }

        [DebuggerNonUserCode()]
        protected override void OnRowDeleting(DataRowChangeEventArgs e)
        {
            base.OnRowDeleting(e);
            if (TabCtrlDocRowDeleting is not null)
            {
                TabCtrlDocRowDeleting?.Invoke(this, new TabCtrlDocRowChangeEvent((TabCtrlDocRow)e.Row, e.Action));
            }
        }

        [DebuggerNonUserCode()]
        public void RemoveTabCtrlDocRow(TabCtrlDocRow row)
        {
            Rows.Remove(row);
        }

        [DebuggerNonUserCode()]
        public static System.Xml.Schema.XmlSchemaComplexType GetTypedTableSchema(System.Xml.Schema.XmlSchemaSet xs)
        {
            var type = new System.Xml.Schema.XmlSchemaComplexType();
            var sequence = new System.Xml.Schema.XmlSchemaSequence();
            var ds = new dstConfig();
            var any1 = new System.Xml.Schema.XmlSchemaAny();
            any1.Namespace = "http://www.w3.org/2001/XMLSchema";
            any1.MinOccurs = new decimal(0);
            any1.MaxOccurs = decimal.MaxValue;
            any1.ProcessContents = System.Xml.Schema.XmlSchemaContentProcessing.Lax;
            sequence.Items.Add(any1);
            var any2 = new System.Xml.Schema.XmlSchemaAny();
            any2.Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1";
            any2.MinOccurs = new decimal(1);
            any2.ProcessContents = System.Xml.Schema.XmlSchemaContentProcessing.Lax;
            sequence.Items.Add(any2);
            var attribute1 = new System.Xml.Schema.XmlSchemaAttribute();
            attribute1.Name = "namespace";
            attribute1.FixedValue = ds.Namespace;
            type.Attributes.Add(attribute1);
            var attribute2 = new System.Xml.Schema.XmlSchemaAttribute();
            attribute2.Name = "tableTypeName";
            attribute2.FixedValue = "TabCtrlDocDataTable";
            type.Attributes.Add(attribute2);
            type.Particle = sequence;
            System.Xml.Schema.XmlSchema dsSchema = ds.GetSchemaSerializable;
            if (xs.Contains(dsSchema.TargetNamespace))
            {
                var s1 = new MemoryStream();
                var s2 = new MemoryStream();
                try
                {
                    System.Xml.Schema.XmlSchema schema = null;
                    dsSchema.Write(s1);
                    var schemas = xs.Schemas(dsSchema.TargetNamespace).GetEnumerator();
                    while (schemas.MoveNext())
                    {
                        schema = (System.Xml.Schema.XmlSchema)schemas.Current;
                        s2.SetLength(0L);
                        schema.Write(s2);
                        if (s1.Length == s2.Length)
                        {
                            s1.Position = 0L;
                            s2.Position = 0L;

                            while (s1.Position != s1.Length && s1.ReadByte() == s2.ReadByte())
                            {


                            }
                            if (s1.Position == s1.Length)
                            {
                                return type;
                            }
                        }

                    }
                }
                finally
                {
                    if (s1 is not null)
                    {
                        s1.Close();
                    }
                    if (s2 is not null)
                    {
                        s2.Close();
                    }
                }
            }
            xs.Add(dsSchema);
            return type;
        }

        /// <summary>
    /// funzione che da il via ai controlli scorrendo la tabella TabCtrlDoc, filtrando il campo 'CDOper1' per cqpire se la riga è quella che contiene il cotnrollo da eseguire in quel momento
    /// </summary>
    /// <param name="rowVWdoc">DataRow con i valori da controllare</param>
    /// <param name="colConnectionStrings">Elenco delle connessioni disponibili</param>
    /// <param name="strFiltro">campo di filtro per selezionare i controlli</param>
    /// <param name="strCausale">nome del campo contenente il codice causale</param>
    /// <param name="blnNotOnlyEnd"> se è true il controllo va effettuato solo al salvataggio del record </param>
    /// <returns></returns>
        public clsCtrlRisultato fncStartCtrl(DataRow rowVWdoc, ref ValuesControlCollection colDecodCtrl, Dictionary<int, string> colConnectionStrings, string strFiltro, string strCausale, ref string strQryLog, ref string strErrCtrl, int intOnlyEnd)
        {
            // Optional ByVal blnNotOnlyEnd As Boolean = False) As clsCtrlRisultato

            dstConfigTableAdapters.tbaTabCtrlDoc adapterCtrl;
            var tabCtrl = new TabCtrlDocDataTable();
            bool blnRisCtrl = true;
            string strCodCau;
            var dllDB = new GsLibCeDB.GsDBADO();
            var Risultato = new clsCtrlRisultato();
            decimal DiffTotPeso;

            strQryLog = string.Empty;
            strErrCtrl = string.Empty;
            blnRisCtrl = true;
            adapterCtrl = new dstConfigTableAdapters.tbaTabCtrlDoc();
            Risultato.NomeCampo = string.Empty;
            Risultato.Risultato = true;
            DiffTotPeso = 0m;

            // apro connessione per caricare i dati

            // leggo la Causale 
            strCodCau = Convert.ToString(dllDB.NullFldObj(rowVWdoc, strCausale, ""));

            adapterCtrl.Connection = dllG3Bce.SQLGes.MakeNewCnn(colConnectionStrings[0]);

            // carica i controlli da effetture 
            if (string.IsNullOrEmpty(strFiltro))
            {
                // carico tutti i controlli
                adapterCtrl.FillSave(tabCtrl, strCodCau);
            }
            else
            {
                // carico i controlli sul campo indicato
                adapterCtrl.Fill(tabCtrl, strCodCau, strFiltro);
            }

            // recupera il riferimento DEI CONTROLLI
            foreach (TabCtrlDocRow rowCtrl in tabCtrl)
            {

                rowCtrl.QryCtrlText = string.Empty;

                // controllo se devo eseguire ora il controllo o alla fine
                // (blnUltimaRiga = False And rowCtrl.CDFlgOnlyEnd = 2)
                if (intOnlyEnd != 1 & rowCtrl.CDFlgOnlyEnd == 1 | rowCtrl.CDFlgOnlyEnd == 2 & intOnlyEnd != 2 | rowCtrl.CDFlgOnlyEnd == 0 & intOnlyEnd == 2)
                {

                    // il controllo va effettuato alla fine e dovrò ricevere gestOnlyEnd=true
                    blnRisCtrl = true;
                    Risultato.Risultato = true;
                    Risultato.NomeCampo = string.Empty;
                }

                else // gestOnlyEnd = True And rowCtrl.CDFlgOnlyEnd = 1
                {

                    // è il controllo che devo effettuare, quindi lo svolgo
                    blnRisCtrl = rowCtrl.fncControlli(rowVWdoc, ref colDecodCtrl, colConnectionStrings);

                    // restituisce info su errori
                    strErrCtrl = strErrCtrl + " " + rowCtrl.CDDescrizione + " " + rowCtrl.ExceptionText + "--";
                    // restituisce info su comandi eseguiti
                    strQryLog = strQryLog + rowCtrl.QryCtrlText + " GO ";

                    // se il primo controllo bloccante fallisce esce dal ciclo
                    if (!blnRisCtrl)
                    {
                        Risultato.Risultato = false;
                        Risultato.NomeCampo = rowCtrl.CDOper1;
                        return Risultato;
                    }

                } // gestOnlyEnd = True And rowCtrl.CDFlgOnlyEnd = 1

            }

            return Risultato;

        } // fncStartCtrl


        /// <summary>
    /// Classe contentente l'oggetto utilizzato per la gestione del risultato dei cotnrolli
    /// </summary>
        public partial class clsCtrlRisultato
        {

            private string strNomeCampo;
            private bool blnRisultato;

            public string NomeCampo
            {
                get
                {
                    return strNomeCampo;
                }

                set
                {
                    strNomeCampo = value;
                }

            }

            public bool Risultato
            {
                get
                {
                    return blnRisultato;
                }

                set
                {
                    blnRisultato = value;
                }

            }

        }

    }

    // ___________________________________________________________________________________________________________________________________________________
    public partial class TabCtrlDocRow : DataRow
    {

        private TabCtrlDocDataTable tableTabCtrlDoc;

        [DebuggerNonUserCode()]
        internal TabCtrlDocRow(DataRowBuilder rb) : base(rb)
        {
            tableTabCtrlDoc = (TabCtrlDocDataTable)Table;
        }

        [DebuggerNonUserCode()]
        public int CDCodice
        {
            get
            {
                return Conversions.ToInteger(this[tableTabCtrlDoc.CDCodiceColumn]);
            }
            set
            {
                this[tableTabCtrlDoc.CDCodiceColumn] = value;
            }
        }

        [DebuggerNonUserCode()]
        public string CDDescrizione
        {
            get
            {
                return Conversions.ToString(this[tableTabCtrlDoc.CDDescrizioneColumn]);
            }
            set
            {
                this[tableTabCtrlDoc.CDDescrizioneColumn] = value;
            }
        }

        [DebuggerNonUserCode()]
        public string CDCodCau
        {
            get
            {
                try
                {
                    return Conversions.ToString(this[tableTabCtrlDoc.CDCodCauColumn]);
                }
                catch (InvalidCastException e)
                {
                    throw new StrongTypingException("The value for column 'CDCodCau' in table 'TabCtrlDoc' is DBNull.", e);
                }
            }
            set
            {
                this[tableTabCtrlDoc.CDCodCauColumn] = value;
            }
        }

        [DebuggerNonUserCode()]
        public int CDFlgDisab
        {
            get
            {
                try
                {
                    return Conversions.ToInteger(this[tableTabCtrlDoc.CDFlgDisabColumn]);
                }
                catch (InvalidCastException e)
                {
                    throw new StrongTypingException("The value for column 'CDFlagDisab' in table 'TabCtrlDoc' is DBNull.", e);
                }
            }
            set
            {
                this[tableTabCtrlDoc.CDFlgDisabColumn] = value;
            }
        }

        [DebuggerNonUserCode()]
        public string CDOper1
        {
            get
            {
                try
                {
                    return Conversions.ToString(this[tableTabCtrlDoc.CDOper1Column]);
                }
                catch (InvalidCastException e)
                {
                    throw new StrongTypingException("The value for column 'CDOper1' in table 'TabCtrlDoc' is DBNull.", e);
                }
            }
            set
            {
                this[tableTabCtrlDoc.CDOper1Column] = value;
            }
        }

        [DebuggerNonUserCode()]
        public string CDOperatore
        {
            get
            {
                if (IsCDOperatoreNull())
                {
                    return string.Empty;
                }
                else
                {
                    return Conversions.ToString(this[tableTabCtrlDoc.CDOperatoreColumn]);
                }
            }
            set
            {
                this[tableTabCtrlDoc.CDOperatoreColumn] = value;
            }
        }

        [DebuggerNonUserCode()]
        public string CDOper2Val
        {
            get
            {
                try
                {
                    return Conversions.ToString(this[tableTabCtrlDoc.CDOper2ValColumn]);
                }
                catch (InvalidCastException e)
                {
                    throw new StrongTypingException("The value for column 'CDOper2Val' in table 'TabCtrlDoc' is DBNull.", e);
                }
            }
            set
            {
                this[tableTabCtrlDoc.CDOper2ValColumn] = value;
            }
        }

        [DebuggerNonUserCode()]
        public int CDOper2Tipo
        {
            get
            {
                try
                {
                    return Conversions.ToInteger(this[tableTabCtrlDoc.CDOper2TipoColumn]);
                }
                catch (InvalidCastException e)
                {
                    throw new StrongTypingException("The value for column 'CDOper2Tipo' in table 'TabCtrlDoc' is DBNull.", e);
                }
            }
            set
            {
                this[tableTabCtrlDoc.CDOper2TipoColumn] = value;
            }
        }

        [DebuggerNonUserCode()]
        public bool CDFlgBloc
        {
            get
            {
                try
                {
                    return Conversions.ToBoolean(this[tableTabCtrlDoc.CDFlgBlocColumn]);
                }
                catch (InvalidCastException e)
                {
                    throw new StrongTypingException("The value for column 'CDFlgBloc' in table 'TabCtrlDoc' is DBNull.", e);
                }
            }
            set
            {
                this[tableTabCtrlDoc.CDFlgBlocColumn] = value;
            }
        }

        [DebuggerNonUserCode()]
        public int CDFlgOnlyEnd
        {
            get
            {
                try
                {
                    return Conversions.ToInteger(this[tableTabCtrlDoc.CDFlgOnlyEndColumn]);
                }
                catch (InvalidCastException e)
                {
                    throw new StrongTypingException("The value for column 'CDFlgOnlyEnd' in table 'TabCtrlDoc' is DBNull.", e);
                }
            }
            set
            {
                this[tableTabCtrlDoc.CDFlgOnlyEndColumn] = value;
            }
        }

        [DebuggerNonUserCode()]
        public string CDMessaggio
        {
            get
            {
                try
                {
                    return Conversions.ToString(this[tableTabCtrlDoc.CDMessaggioColumn]);
                }
                catch (InvalidCastException e)
                {
                    throw new StrongTypingException("The value for column 'CDMessaggio' in table 'TabCtrlDoc' is DBNull.", e);
                }
            }
            set
            {
                this[tableTabCtrlDoc.CDMessaggioColumn] = value;
            }
        }

        [DebuggerNonUserCode()]
        public byte CDCodCnn
        {
            get
            {
                try
                {
                    return Conversions.ToByte(this[tableTabCtrlDoc.CDCodCnnColumn]);
                }
                catch (InvalidCastException e)
                {
                    throw new StrongTypingException("The value for column 'CDCodCnn' in table 'TabCampi' is DBNull.", e);
                }
            }
            set
            {
                this[tableTabCtrlDoc.CDCodCnnColumn] = value;
            }
        }


        [DebuggerNonUserCode()]
        public int CDOrdine
        {
            get
            {
                try
                {
                    return Conversions.ToInteger(this[tableTabCtrlDoc.CDOrdineColumn]);
                }
                catch (InvalidCastException e)
                {
                    throw new StrongTypingException("The value for column 'CDOrdine' in table 'TabCampi' is DBNull.", e);
                }
            }
            set
            {
                this[tableTabCtrlDoc.CDOrdineColumn] = value;
            }
        }


        /// <summary>Testo in formato SQL del controllo</summary>
    /// <returns></returns>
        private string strQryCtrl;
        public string QryCtrlText
        {
            get
            {
                return strQryCtrl;
            }
            set
            {
                strQryCtrl = value;
            }
        }

        /// <summary>Testo dell'eccezione generata dall'esecuzione del controllo</summary>
    /// <returns></returns>
        private string strExceptionText;
        public string ExceptionText
        {
            get
            {
                return strExceptionText;
            }
            set
            {
                strExceptionText = value;
            }
        }



        [DebuggerNonUserCode()]
        public bool IsCDCodiceNull()
        {
            return IsNull(tableTabCtrlDoc.CDCodiceColumn);
        }


        [DebuggerNonUserCode()]
        public bool IsCDDescrizioneNull()
        {
            return IsNull(tableTabCtrlDoc.CDDescrizioneColumn);
        }

        [DebuggerNonUserCode()]
        public void SetCDDescrizioneNull()
        {
            this[tableTabCtrlDoc.CDDescrizioneColumn] = Convert.DBNull;
        }

        [DebuggerNonUserCode()]
        public int IsCDFlgDisabNull()
        {
            return Conversions.ToInteger(IsNull(tableTabCtrlDoc.CDFlgDisabColumn));
        }

        [DebuggerNonUserCode()]
        public void SetCDFlgDisabNull()
        {
            this[tableTabCtrlDoc.CDFlgDisabColumn] = Convert.DBNull;
        }

        [DebuggerNonUserCode()]
        public bool IsCDOper1Null()
        {
            return IsNull(tableTabCtrlDoc.CDOper1Column);
        }

        [DebuggerNonUserCode()]
        public void SetCDOper1Null()
        {
            this[tableTabCtrlDoc.CDOper1Column] = Convert.DBNull;
        }

        [DebuggerNonUserCode()]
        public bool IsCDOperatoreNull()
        {
            return IsNull(tableTabCtrlDoc.CDOperatoreColumn);
        }

        [DebuggerNonUserCode()]
        public void SetCDOperatoreNull()
        {
            this[tableTabCtrlDoc.CDOperatoreColumn] = Convert.DBNull;
        }

        [DebuggerNonUserCode()]
        public bool IsCDCodCauNull()
        {
            return IsNull(tableTabCtrlDoc.CDCodCauColumn);
        }

        [DebuggerNonUserCode()]
        public void SetCDCodCauNull()
        {
            this[tableTabCtrlDoc.CDCodCauColumn] = Convert.DBNull;
        }

        [DebuggerNonUserCode()]
        public bool IsCDOper2ValNull()
        {
            return IsNull(tableTabCtrlDoc.CDOper2ValColumn);
        }

        [DebuggerNonUserCode()]
        public void SetCDOper2ValNull()
        {
            this[tableTabCtrlDoc.CDOper2ValColumn] = Convert.DBNull;
        }

        [DebuggerNonUserCode()]
        public bool IsCDOper2TipoNull()
        {
            return IsNull(tableTabCtrlDoc.CDOper2TipoColumn);
        }

        [DebuggerNonUserCode()]
        public void SetCDOper2TipoNull()
        {
            this[tableTabCtrlDoc.CDOper2TipoColumn] = Convert.DBNull;
        }

        [DebuggerNonUserCode()]
        public bool IsCDFlgBlocNull()
        {
            return IsNull(tableTabCtrlDoc.CDFlgBlocColumn);
        }

        [DebuggerNonUserCode()]
        public void SetCDFlgBlocNull()
        {
            this[tableTabCtrlDoc.CDFlgBlocColumn] = Convert.DBNull;
        }

        [DebuggerNonUserCode()]
        public int IsCDFlgOnlyEndNull()
        {
            return Conversions.ToInteger(IsNull(tableTabCtrlDoc.CDFlgOnlyEndColumn));
        }

        [DebuggerNonUserCode()]
        public void SetCDMessaggioNull()
        {
            this[tableTabCtrlDoc.CDMessaggioColumn] = Convert.DBNull;
        }


        [DebuggerNonUserCode()]
        public bool IsCDCodCnnNull()
        {
            return IsNull(tableTabCtrlDoc.CDCodCnnColumn);
        }

        [DebuggerNonUserCode()]
        public void SetCDCodCnnNullCodCnnNull()
        {
            this[tableTabCtrlDoc.CDCodCnnColumn] = Convert.DBNull;
        }


        [DebuggerNonUserCode()]
        public bool IsCDOrdineNull()
        {
            return IsNull(tableTabCtrlDoc.CDOrdineColumn);
        }

        [DebuggerNonUserCode()]
        public void SetCDOrdineNullCodCnnNull()
        {
            this[tableTabCtrlDoc.CDOrdineColumn] = Convert.DBNull;
        }

        /// <summary>
    /// Funzione che inizia a effettuare il contrllo selezionato precedentemente, caricando i dati 
    /// </summary>
    /// <param name="vwDocrow">riga dei dati presenti nel form</param>
    /// <param name="cnn">tipo di connessione</param>
    /// <param name="fOper1">filtro su operatore 1</param>
    /// <param name="ctrlMsg"> True visualizzo il messaggio dato dal controllo altrimenti no</param>
    /// <returns></returns>
        public bool fncControlli(DataRow vwDocrow, ref ValuesControlCollection colDecodCtrl, Dictionary<int, string> colConnectionStrings)
        {

            string strMessaggio;
            bool blnRisultato;
            var dllDB = new GsLibCeDB.GsDBADO();
            // Dim raccDecodCtrl As ValuesControlCollection
            // creo una raccolta di (come si chiama esattamente?)
            // raccDecodCtrl = vwDocrow.fncAddRaccCtrl()

            // eseguo il controllo
            blnRisultato = this.fncEseguiControllo(vwDocrow, ref colDecodCtrl, colConnectionStrings);

            if (blnRisultato == true)
            {

                // controllo andato a buon fine
                Debug.WriteLine(" fncControlli : controllo andato a buon fine");
                return true;
            }

            else
            {

                // faccio visualizzare il messaggio contenuto nella riga
                strMessaggio = CDMessaggio;
                // decodifico i valori presenti nel messaggio
                // utilizzo la Funzione ReplaceAllTags per sostituire "@Nome" col suo valore all'interno della stringa
                strMessaggio = colDecodCtrl.ReplaceAllTags(strMessaggio);


                // controllo l'esito del controllo, se è false e il controllo è bloccante blocco l'esecuzione
                if (CDFlgBloc == true)
                {

                    // stampo la messagboxx
                    Messages.MessageInfo.Show(strMessaggio);
                }
                else
                {
                    // aggiunge domanda all'utente per consentire di avanzare comunque
                    strMessaggio += Constants.vbCrLf + "Continuare?";
                    // richiesta all'utente
                    if (Messages.MessageInfo.ShowQuestion(strMessaggio, Windows.Forms.MessageBoxDefaultButton.Button2) == Constants.vbYes)
                    {

                        // consente all'esecuzione di proseguire
                        return true;
                    }

                }

                // blocca l'esecuzione
                return false;
            } // (risultato = True)

        } // Controlli


        /// <summary>
    /// Funzione per eseguire la valutazione di un controllo
    /// </summary>
    /// <param name="rowRecordDaControllare">Insieme die valori da controllare</param>
    /// <returns>Restituisce true per indicare che il controllo è andato a buon fine, false indica che il controllo ha degli errori</returns>
        public bool fncEseguiControllo(DataRow vwDocRow, ref Utility.ValuesControlCollection colDecodCtrl, Dictionary<int, string> colConnectionStrings)
        {

            string strSQL;
            object objVal1;
            string strVal2;
            string strOperatore;
            string strOperando2Val;
            string strOperando2Tipo;
            var dllDB = new GsLibCeDB.GsDBADO();
            int cnnDB;
            int risultato;
            object objRisultato;
            string strOperando1;
            var arrPram = new string[9];
            decimal decQtaPrelCalc = 0m;
            string strCompare = string.Empty;


            try
            {

                // recupero il valore dell'operando di riferimento controllando se è null
                strOperando1 = dllDB.NullFldObj(this, "CDOper1", "");

                strCompare = vwDocRow.Table.Columns[strOperando1].DataType.ToString();

                // strComparer = objVal1DataType.FullName.ToString

                switch (strCompare ?? "")
                {

                    case "System.Decimal":
                        {
                            // se il campo in riga è DBNULL inserisco 0 nell'oggetto
                            objVal1 = dllDB.NullFldObj(vwDocRow, strOperando1, 0);
                            // controllo se il campo è vuoto
                            if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(objVal1, 0, false)))
                            {
                                strCompare = string.Empty;
                            }
                            // inserisco il valore trovato nella raccolta
                            colDecodCtrl.Item("Operando1").Value = dllDB.SQLNumeric(objVal1);
                            break;
                        }

                    case "System.DateTime":
                        {
                            // se il campo in riga è DBNULL inserisco 01/01/0001 nell'oggetto
                            objVal1 = dllDB.NullFldObj(vwDocRow, strOperando1, DateTime.MinValue);
                            // controllo se il campo è vuoto
                            if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(objVal1, DateTime.MinValue, false)))
                            {
                                strCompare = string.Empty;
                            }
                            // inserisco il valore trovato nella raccolta
                            colDecodCtrl.Item("Operando1").Value = dllDB.SQLDate(objVal1);
                            break;
                        }

                    case "System.Boolean":
                        {
                            // se il campo in riga è DBNULL inserisco False nell'oggetto
                            objVal1 = dllDB.NullFldObj(vwDocRow, strOperando1, false);
                            // controllo se il campo è vuoto
                            if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(objVal1, false, false)))
                            {
                                strCompare = string.Empty;
                            }
                            // inserisco il valore trovato nella raccolta
                            colDecodCtrl.Item("Operando1").Value = dllDB.SQLBoolean(objVal1);
                            break;
                        }

                    default:
                        {
                            // se il campo in riga è DBNULL inserisco empty nell'oggetto
                            objVal1 = dllDB.NullFldObj(vwDocRow, strOperando1, string.Empty);
                            // controllo se il campo è vuoto
                            if (string.IsNullOrEmpty(objVal1.ToString()))
                            {
                                strCompare = string.Empty;
                            }
                            // inserisco il valore trovato nella raccolta
                            colDecodCtrl.Item("Operando1").Value = dllDB.SQLString(objVal1);
                            break;
                        }

                }


                // Controllo sul bloccante se valorizzato
                // strCompare è vuoto significa che il valore della riga era DBNULL
                if (dllDB.NullFldInt(this, "CDFlgDisab") == 1 & string.IsNullOrEmpty(strCompare))
                {
                    // restituisco true perchè il controllo non va effettuato
                    return true;
                }

                // recupero tipo e valore dell'operando 2 e opertore in modo da valutarli nella fncGetValore2()
                strOperatore = dllDB.NullFldObj(this, "CDOperatore", "");
                strOperando2Val = dllDB.NullFldObj(this, "CDOper2Val", "");
                strOperando2Tipo = dllDB.NullFldObj(this, "CDOper2Tipo", "");

                // recupero il codice della connessione da utilizare
                cnnDB = dllDB.NullFldInt(this, "CDCodCnn");
                // funzione gestisce l operatore 2 e lo restituisce pronto per esser utilizzato
                // se è Func i tag verranno cambiati in face di creazione della query
                // se è tag è già pronto per l'utilizzo
                strVal2 = Conversions.ToString(fncGetValore2(strOperando2Val, colDecodCtrl));
                // genero la query
                strSQL = fncCreaQry(Convert.ToString(colDecodCtrl.Item("Operando1").Value), strVal2, strOperatore, ref colDecodCtrl);

                // la Qry viene scritta in tabella per sriverla nel log 
                QryCtrlText = strSQL;
                ExceptionText = string.Empty;

                if (!string.IsNullOrEmpty(strSQL))
                {

                    try
                    {
                        // eseguo la query
                        objRisultato = SQLGes.fncExecQry(strSQL, cnnDB, colConnectionStrings);

                        risultato = Convert.ToInt32(objRisultato);
                    }

                    catch (Exception ex)
                    {
                        risultato = 0;
                        // Messaggio di errore generato dall'esecuzione del controllo
                        ExceptionText = Messages.MessageErr.GetText("fncExecQry()", ex);

                    }
                }

                else
                {

                    Debug.WriteLine(" fncEseguiControllo : la stringa contenente la qry è VUOTA");
                    risultato = 0;

                }

                // eseguo il controllo sul risultato
                if (risultato == 1)
                {
                    Debug.WriteLine(" fncEseguiControllo : Risultato CTRL corretto");
                    return true;
                }
                else
                {
                    Debug.WriteLine(" fncEseguiControllo : Risultato CTRL NON corretto");
                    return false;
                }
            }

            catch (Exception ex)
            {
                ExceptionText = Messages.MessageErr.GetText("fncEseguiControllo()", ex);
                return false;
            }

        }



        /// <summary>
    /// Funzione che riceve il tipo e il valore di operando ed in base ad essi trova il valore corretto da restituire
    /// </summary>
    /// <param name="strOp2Val">valore dell'operando 2 da valutare</param>
    /// <param name="strOp2Tipo">tipo dell'operando</param>
    /// <returns>ritorna il valore dell'operando 2 pronto per esser inserito nella query</returns>
        private object fncGetValore2(string strOp2Val, Utility.ValuesControlCollection raccDecodCtrl)
        {

            string strVal2;

            // utilizzo la Funzione ReplaceAllTags per sostituire "@Nome" col suo valore all'interno della stringa
            strVal2 = raccDecodCtrl.ReplaceAllTags(strOp2Val);

            return strVal2;

        }

        /// <summary>
    /// Funzione che restituisce la query formattata per la verifica finale del controllo
    /// </summary>
    /// <param name="Valore1">Valore da controllare</param>
    /// <param name="Valore2">Valore di riferimento</param>
    /// <param name="Operatore">Operatore da utilizzare nel controllo</param>
    /// <returns></returns>
        private string fncCreaQry(string Valore1, string Valore2, string Operatore, ref Utility.ValuesControlCollection raccDecodCtrl)
        {

            string strQry;
            string strWQry;
            var dllDB = new GsLibCeDB.GsDBADO();


            // genero la query
            strWQry = "SELECT 1 WHERE " + Valore1 + " " + Operatore + " " + Valore2;

            Debug.WriteLine(" fncCreaQry : " + strWQry);

            // eseguo la sostituzione dei tag
            strQry = raccDecodCtrl.ReplaceAllTags(strWQry);

            // restituisco query
            return strQry;

        } // fncCreaQry



    }

    // ________________________________________________________________________________________________________________________________________
    /// <summary>
  /// Row event argument class
  /// </summary>
    public partial class TabCtrlDocRowChangeEvent : EventArgs
    {

        private TabCtrlDocRow eventRow;

        private DataRowAction eventAction;

        [DebuggerNonUserCode()]
        public TabCtrlDocRowChangeEvent(TabCtrlDocRow row, DataRowAction action) : base()
        {
            eventRow = row;
            eventAction = action;
        }

        [DebuggerNonUserCode()]
        public TabCtrlDocRow Row
        {
            get
            {
                return eventRow;
            }
        }

        [DebuggerNonUserCode()]
        public DataRowAction Action
        {
            get
            {
                return eventAction;
            }
        }
    }
}