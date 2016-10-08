using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MusicTool;
using MusicTool.Datenbank;

namespace MusicTool.Basisklassen
{
	/// <summary> Klasse       : bcl_BasisListe
	/// <para>Basisklasse für allen Listen-basierten Klassen</para>
	/// .
	/// <para>    Programmierer    : Michael Pütz</para>
	/// <para>    getestet am      : </para>
	/// </summary>
	public class bcl_BasisListe<T> : bcl_Basisdaten where T : bcl_Basisdaten
	{
		#region VersionInfo

		private static string zz_klassenName= "bcl_BasisListe";
		private static string zz_namespace = "MusicTool.Basisklassen";
		private static dType zz_datenTyp = dType.Basisliste;
		private static string zz_hauptversion= "0";
		private static string zz_nebenversion= "1";
		private static string zz_revision= "4";
		private static string zz_letzteBearbeitung= "2016-10-06  15:29:29";
		private static string zz_ersteBearbeitung= "2016-07-10 15:26.52";
		private static string zz_getestet= "";
		#region VersionInfoEigenschaften
		/// <summary> Eigenschaft: zz_KlassenName
		/// <para>gibt den Namen der Klasse aus</para>
		/// <para>TYP: STRING</para>
		/// .
		/// <para>    Programmierer    : Michael Pütz</para>
		///           Version          : 0
		/// <para>    Unterversion     : 1</para>
		///           Revision         : 1
		/// <para>    letzteBearbeitung: 2016-07-10  12:31:43</para>
		/// <para>    ersteBearbeitung : 2016-07-10  12:31:43</para>
		/// .
		/// <para>    getestet am      : </para>
		/// </summary>
		public static new string zz_KlassenName { get { return zz_klassenName; } }
		/// <summary> Eigenschaft: zz_Namespace
		/// <para>gibt den Namespace der Klasse aus</para>
		/// <para>TYP: STRING</para>
		/// .
		/// <para>    Programmierer    : Michael Pütz</para>
		///           Version          : 0
		/// <para>    Unterversion     : 1</para>
		///           Revision         : 1
		/// <para>    letzteBearbeitung: 2016-07-10  12:32:38</para>
		/// <para>    ersteBearbeitung : 2016-07-10  12:32:38</para>
		/// .
		/// <para>    getestet am      : </para>
		/// </summary>
		public static new string zz_Namespace { get { return zz_namespace; } }
		/// <summary> Eigenschaft: zz_Pfad
		/// <para>gibt den Pfad (Namespace + Klassenname) aus</para>
		/// <para>TYP: STRING</para>
		/// .
		/// <para>    Programmierer    : Michael Pütz</para>
		///           Version          : 0
		/// <para>    Unterversion     : 1</para>
		///           Revision         : 1
		/// <para>    letzteBearbeitung: 2016-07-10  12:33:31</para>
		/// <para>    ersteBearbeitung : 2016-07-10  12:33:31</para>
		/// .
		/// <para>    getestet am      : </para>
		/// </summary>
		public static new string zz_Pfad { get { return zz_namespace + "." + zz_klassenName; } }
		/// <summary> Eigenschaft: zz_VersionInfo
		/// <para>gibt die Version der Klasse aus</para>
		/// <para>TYP: STRING</para>
		/// .
		/// <para>    Programmierer    : Michael Pütz</para>
		///           Version          : 0
		/// <para>    Unterversion     : 1</para>
		///           Revision         : 1
		/// <para>    letzteBearbeitung: 2016-07-10  12:34:43</para>
		/// <para>    ersteBearbeitung : 2016-07-10  12:34:43</para>
		/// .
		/// <para>    getestet am      : </para>
		/// </summary>
		public static new string zz_VersionInfo
		{
			get {
				return "Version: " + zz_hauptversion + "." + zz_nebenversion +
			  ", Revision: " + zz_revision;
			}
		}
		/// <summary> Eigenschaft: zz_AktBearbeitung
		/// <para>gibt das Datum der letzten Bearbeitung der Klasse aus</para>
		/// <para>TYP: STRING</para>
		/// .
		/// <para>    Programmierer    : Michael Pütz</para>
		///           Version          : 0
		/// <para>    Unterversion     : 1</para>
		///           Revision         : 1
		/// <para>    letzteBearbeitung: 2016-07-10  12:35:45</para>
		/// <para>    ersteBearbeitung : 2016-07-10  12:35:45</para>
		/// .
		/// <para>    getestet am      : </para>
		/// </summary>
		public static new string zz_AktBearbeitung { get { return zz_letzteBearbeitung; } }
		/// <summary> Eigenschaft: zz_BearbeitungsBeginn
		/// <para>gibt aus, ab wann diese Klasse programmiert wurde</para>
		/// <para>TYP: STRING</para>
		/// .
		/// <para>    Programmierer    : Michael Pütz</para>
		///           Version          : 0
		/// <para>    Unterversion     : 1</para>
		///           Revision         : 1
		/// <para>    letzteBearbeitung: 2016-07-10  12:36:44</para>
		/// <para>    ersteBearbeitung : 2016-07-10  12:36:44</para>
		/// .
		/// <para>    getestet am      : </para>
		/// </summary>
		public static new string zz_BearbeitungsBeginn { get { return zz_ersteBearbeitung; } }
		/// <summary> Eigenschaft: zz_DatenTyp
		/// <para>gibt den Datentyp der Klasse aus</para>
		/// <para>TYP: dType</para>
		/// .
		/// <para>    Programmierer    : Michael Pütz</para>
		///           Version          : 0
		/// <para>    Unterversion     : 1</para>
		///           Revision         : 1
		/// <para>    letzteBearbeitung: 2016-07-10  12:37:35</para>
		/// <para>    ersteBearbeitung : 2016-07-10  12:37:35</para>
		/// .
		/// <para>    getestet am      : </para>
		/// </summary>
		public static new dType zz_DatenTyp { get { return zz_datenTyp; } }
		/// <summary> Eigenschaft: zz_Getestet
		/// <para>gibt aus, wann die Klasse getestet wurde</para>
		/// <para>TYP: STRING</para>
		/// .
		/// <para>    Programmierer    : Michael Pütz</para>
		///           Version          : 0
		/// <para>    Unterversion     : 1</para>
		///           Revision         : 1
		/// <para>    letzteBearbeitung: 2016-07-10  12:43:07</para>
		/// <para>    ersteBearbeitung : 2016-07-10  12:43:07</para>
		/// .
		/// <para>    getestet am      : </para>
		/// </summary>
		public static new string zz_Getestet { get { return zz_getestet; } }
		#endregion VersionInfoEigenschaften

		#endregion VersionInfo

		#region Attribute

		/// <summary>Liste der Elemente (Töne /  Intervalle)
		/// <para> TYP: Liste vom virtuellen Datentyp "T" </para>
		/// </summary>
		private List<T> _liste;

		#endregion Attribute

		#region Konstruktor

		/// <summary> Konstruktor(_index,_name,typ, PARAMS daten)
		/// <para>initialisiert die Klasse mit allen benötigten Daten</para>
		/// .
		/// <para>    Programmierer    : Michael Pütz</para>
		///           Version          : 0
		/// <para>    Unterversion     : 1</para>
		///           Revision         : 1
		/// <para>    letzteBearbeitung: 2016-09-18  16:47:12</para>
		/// <para>    ersteBearbeitung : 2016-07-10  15:37:33</para>
		/// .
		/// <para>    getestet am      : </para>
		/// </summary>
		/// <param name="_index">Index der Datenliste, TYP: INT</param>
		/// <param name="_name">Name der Datenliste, TYP: STRING</param>
		/// <param name="typ">Typ der Datenliste, TYP: dType</param>
		public bcl_BasisListe( int _index , string _name , dType typ ) : base( _name , "" , _index , typ )
		{
			_liste = new List<T>();
		}

		/// <summary> Konstruktor(_index,_name,typ, PARAMS daten)
		/// <para>initialisiert die Klasse mit allen benötigten Daten</para>
		/// .
		/// <para>    Programmierer    : Michael Pütz</para>
		///           Version          : 0
		/// <para>    Unterversion     : 1</para>
		///           Revision         : 3
		/// <para>    letzteBearbeitung: 2016-10-06  12:39:23</para>
		/// <para>    ersteBearbeitung : 2016-07-10  15:37:33</para>
		/// .
		/// <para>    getestet am      : </para>
		/// </summary>
		/// <param name="_index">Index der Datenliste, TYP: INT</param>
		/// <param name="_name">Name der Datenliste, TYP: STRING</param>
		/// <param name="typ">Typ der Datenliste, TYP: dType</param>
		/// <param name="daten">Liste mit allen Daten, GENERISCHER  TYP: Liste von T</param>
		public bcl_BasisListe( int _index , string _name , dType typ , List<T> daten ) : base( _name , "" , _index , typ )
		{
			_liste = daten;
		}

		/// <summary> Konstruktor(_index,_name,_name2,typ, PARAMS daten)
		/// <para>initialisiert die Klasse mit allen benötigten Daten</para>
		/// .
		/// <para>    Programmierer    : Michael Pütz</para>
		///           Version          : 0
		/// <para>    Unterversion     : 1</para>
		///           Revision         : 3
		/// <para>    letzteBearbeitung: 2016-10-06  12:42:28</para>
		/// <para>    ersteBearbeitung : 2016-07-10  15:37:33</para>
		/// .
		/// <para>    getestet am      : </para>
		/// </summary>
		/// <param name="_index">Index der Datenliste, TYP: INT</param>
		/// <param name="_name">Name der Datenliste, TYP: STRING</param>
		/// <param name="_name2">2.Name der Datenliste, TYP: STRING</param>
		/// <param name="typ">Typ der Datenliste, TYP: dType</param>
		/// <param name="daten">Liste mit allen Daten, GENERISCHER TYP: Liste von T</param>
		public bcl_BasisListe( int _index , string _name , string _name2 , dType typ , List<T> daten ) : base( _name , _name2 , _index , typ )
		{
			_liste = daten;
		}

		#endregion Konstruktor

		#region Eigenschaften

		/// <summary> Eigenschaft: Anzahl
		/// <para>gibt die Anzahl der gespeicherten Elemente aus</para>
		/// <para>TYP: INT</para>
		/// .
		/// <para>    Programmierer    : Michael Pütz</para>
		///           Version          : 0
		/// <para>    Unterversion     : 1</para>
		///           Revision         : 1
		/// <para>    letzteBearbeitung: 2016-07-10  16:17:59</para>
		/// <para>    ersteBearbeitung : 2016-07-10  16:17:59</para>
		/// .
		/// <para>    getestet am      : </para>
		/// </summary>
		public int Anzahl { get { return _liste.Count; } }

		#endregion Eigenschaften

		#region Methoden

		/// <summary> Methode: get(index)
		/// <para>gibt ein Element der Liste aus</para>
		/// .
		/// <para>    Programmierer    : Michael Pütz</para>
		///           Version          : 0
		/// <para>    Unterversion     : 1</para>
		///           Revision         : 2
		/// <para>    letzteBearbeitung: 2016-10-06  11:51:03</para>
		/// <para>    ersteBearbeitung : 2016-07-10  16:19:49</para>
		/// .
		/// <para>    getestet am      : </para>
		/// </summary>
		/// <param name="_index">Index des Elements, TYP: INT</param>
		/// <returns>Element der Liste, GENERISCHER TYP: T</returns>
		public T get( int _index )
		{
			T tmp;

			try {
				tmp = _liste[_index];
			}
			catch( ArgumentOutOfRangeException ) {
				return default(T);
			}

			return tmp;
		}

		/// <summary> Methode: finde(suchName)
		/// <para>sucht nach dem abgegebenen Namen und übergibt bei Gleichheit das gefundene Objekt</para>
		/// .
		/// <para>    Programmierer    : Michael Pütz</para>
		///           Version          : 0
		/// <para>    Unterversion     : 1</para>
		///           Revision         : 1
		/// <para>    letzteBearbeitung: 2016-10-06  15:28:31</para>
		/// <para>    ersteBearbeitung : 2016-10-06  15:28:31</para>
		/// .
		/// <para>    getestet am      : </para>
		/// </summary>
		/// <param name="suchName">Name des gesuchten Objekts, TYP: STRING</param>
		/// <returns>gefundenes Objekt ODER DEFAULT, TYP: T</returns>
		public T finde(string suchName )
		{
			if( suchName == null | suchName == "" ) return default( T );

			for( int i = 0 ; i < _liste.Count ; i++ ) {
				if( _liste[i].Name == suchName ) return _liste[i];
			}

			return default( T );
		}

		#endregion Methoden
	}
}
