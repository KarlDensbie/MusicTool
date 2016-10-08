using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MusicTool;
using MusicTool.Basisklassen;

namespace MusicTool.Datenbank
{
	/// <summary> Klasse       : ValidTonNamen
	/// <para>STATISCHE KLASSE</para>
	/// <para>stellt fest, ob ein Tonname gültig ist</para>
	/// .
	/// <para>    Programmierer    : Michael Pütz</para>
	/// <para>    getestet am      : </para>
	/// </summary>
	public static class ValidTonNamen
	{
		#region VersionInfo

		private static string zz_klassenName= "ValidTonNamen";
		private static string zz_namespace = "MusicTool.Datenbank";
		private static dType zz_datenTyp = dType.Tool;
		private static string zz_hauptversion= "0";
		private static string zz_nebenversion= "1";
		private static string zz_revision= "1";
		private static string zz_letzteBearbeitung= "2016-07-10  20:38:18";
		private static string zz_ersteBearbeitung= "2016-07-10 14:23.23";
		private static string zz_getestet= "";
		#region VersionInfoEigenschaften
		public static string zz_KlassenName { get { return zz_klassenName; } }
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
		public static string zz_Namespace { get { return zz_namespace; } }
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
		public static string zz_Pfad { get { return zz_namespace + "." + zz_klassenName; } }
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
		public static string zz_VersionInfo
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
		public static string zz_AktBearbeitung { get { return zz_letzteBearbeitung; } }
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
		public static string zz_BearbeitungsBeginn { get { return zz_ersteBearbeitung; } }
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
		public static dType zz_DatenTyp { get { return zz_datenTyp; } }
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
		public static string zz_Getestet { get { return zz_getestet; } }
		#endregion VersionInfoEigenschaften

		#endregion VersionInfo

		#region Attribute

		/// <summary>Liste der gültigen Tonnamen
		/// <para>TYP: Liste von STRING</para>
		/// </summary>
		private static List<string> _liste;

		#endregion Attribute

		#region Konstruktor

		/// <summary> STATISCHER Konstruktor()
		/// <para></para>
		/// .
		/// <para>    Programmierer    : Michael Pütz</para>
		///           Version          : 0
		/// <para>    Unterversion     : 1</para>
		///           Revision         : 1
		/// <para>    letzteBearbeitung: 2016-07-10  14:35:54</para>
		/// <para>    ersteBearbeitung : 2016-07-10  14:35:54</para>
		/// .
		/// <para>    getestet am      : </para>
		/// </summary>
		static ValidTonNamen()
		{
			_liste = new List<string>();
			Init();
		}

		/// <summary> Methode: Init()
		/// <para>Initialisiert die Tonliste</para>
		/// .
		/// <para>    Programmierer    : Michael Pütz</para>
		///           Version          : 0
		/// <para>    Unterversion     : 1</para>
		///           Revision         : 1
		/// <para>    letzteBearbeitung: 2016-07-10  14:47:10</para>
		/// <para>    ersteBearbeitung : 2016-07-10  14:47:10</para>
		/// .
		/// <para>    getestet am      : </para>
		/// </summary>
		private static void Init()
		{
			_liste.Add( "Cbb" );
			_liste.Add( "Cb" );
			_liste.Add( "C" );
			_liste.Add( "C#" );
			_liste.Add( "C##" );
			_liste.Add( "Dbb" );
			_liste.Add( "Db" );
			_liste.Add( "D" );
			_liste.Add( "D#" );
			_liste.Add( "D##" );
			_liste.Add( "Ebb" );
			_liste.Add( "Eb" );
			_liste.Add( "E" );
			_liste.Add( "E#" );
			_liste.Add( "E##" );
			_liste.Add( "Fbb" );
			_liste.Add( "Fb" );
			_liste.Add( "F" );
			_liste.Add( "F#" );
			_liste.Add( "F##" );
			_liste.Add( "Gbb" );
			_liste.Add( "Gb" );
			_liste.Add( "G" );
			_liste.Add( "G#" );
			_liste.Add( "G##" );
			_liste.Add( "Abb" );
			_liste.Add( "Ab" );
			_liste.Add( "A" );
			_liste.Add( "A#" );
			_liste.Add( "A##" );
			_liste.Add( "Hbb" );
			_liste.Add( "B" );
			_liste.Add( "H" );
			_liste.Add( "H#" );
			_liste.Add( "H##" );
		}

		#endregion Konstruktor

		#region Eigenschaften

		/// <summary> Eigenschaft: Anzahl
		/// <para>gibt die Anzahl der gespeicherten Tonnamen aus</para>
		/// <para>TYP: INT</para>
		/// .
		/// <para>    Programmierer    : Michael Pütz</para>
		///           Version          : 0
		/// <para>    Unterversion     : 1</para>
		///           Revision         : 1
		/// <para>    letzteBearbeitung: 2016-07-10  14:33:17</para>
		/// <para>    ersteBearbeitung : 2016-07-10  14:33:17</para>
		/// .
		/// <para>    getestet am      : </para>
		/// </summary>
		public static int Anzahl { get { return _liste.Count; } }

		#endregion Eigenschaften

		#region Methoden

		/// <summary> Methode: isValid(name)
		/// <para>stellt fest,ob der angegebene Name ein gültiger Tonname ist</para>
		/// .
		/// <para>    Programmierer    : Michael Pütz</para>
		///           Version          : 0
		/// <para>    Unterversion     : 1</para>
		///           Revision         : 1
		/// <para>    letzteBearbeitung: 2016-07-10  14:35:17</para>
		/// <para>    ersteBearbeitung : 2016-07-10  14:30:57</para>
		/// .
		/// <para>    getestet am      : </para>
		/// </summary>
		public static bool isValid(string name )
		{
			for( int i = 0 ; i < Anzahl ; i++ ) {
				if( _liste[i] == name ) return true;
			}

			return false;
		}

		/// <summary> Methode: getName(_index)
		/// <para>gibt einen Namen aus</para>
		/// <para>wenn der Index UNGÜLTIG ist, wird LEERSTRING ausgegeben</para>
		/// .
		/// <para>    Programmierer    : Michael Pütz</para>
		///           Version          : 0
		/// <para>    Unterversion     : 1</para>
		///           Revision         : 1
		/// <para>    letzteBearbeitung: 2016-07-10  14:52:39</para>
		/// <para>    ersteBearbeitung : 2016-07-10  14:48:27</para>
		/// .
		/// <para>    getestet am      : </para>
		/// </summary>
		/// <param name="_index">Index des Tonnamens, TYP: INT</param>
		/// <returns>Name des Tons, TYP: STRING</returns>
		public static string getName( int _index )
		{
			string tmp = "";

			try {
				tmp = _liste[_index];
			}
			catch( ArgumentOutOfRangeException ) {
				return "";
			}

			return tmp;
		}

		/// <summary> Methode: getName(Ton-Index)
		/// <para>gibt einen Tonnamen aus</para>
		/// <para>wenn der Index UNGÜLTIG ist, wird LEERSTRING ausgegeben</para>
		/// .
		/// <para>    Programmierer    : Michael Pütz</para>
		///           Version          : 0
		/// <para>    Unterversion     : 1</para>
		///           Revision         : 1
		/// <para>    letzteBearbeitung: 2016-07-10  15:10:29</para>
		/// <para>    ersteBearbeitung : 2016-07-10  15:10:29</para>
		/// .
		/// <para>    getestet am      : </para>
		/// </summary>
		/// <param name="ti">Index des Tonnamens, TYP: eTon</param>
		/// <returns>Name des Tons, TYP: STRING</returns>
		public static string getName(eTon ti )
		{
			if( ti == eTon.X ) return "";

			return getName( (int)ti );
		}

		/// <summary> Methode: getTonObj(ti)
		/// <para>gibt ein Ton-Objekt aus</para>
		/// .
		/// <para>    Programmierer    : Michael Pütz</para>
		///           Version          : 0
		/// <para>    Unterversion     : 1</para>
		///           Revision         : 1
		/// <para>    letzteBearbeitung: 2016-07-10  20:35:43</para>
		/// <para>    ersteBearbeitung : 2016-07-10  20:32:13</para>
		/// .
		/// <para>    getestet am      : </para>
		/// </summary>
		/// <param name="ti">Ton-Index, TYP: eTon</param>
		/// <returns>Ton-Objekt mit allen Ton-Daten, TYP: ds_Ton</returns>
		public static ds_Ton getTonObj(eTon ti )
		{
			ds_Ton tmp = null;
			string tmpName = "";

			tmpName = getName( ti );

			switch( tmpName ) {
				case "Cbb":
					tmp = new ds_Ton( tmpName , eTon.Ceses , eGrundton.C , eTon.Ais , eTon.B , dType.Tondaten );
					break;
				case "Cb":
					tmp = new ds_Ton( tmpName , eTon.Ces , eGrundton.C , eTon.Aisis , eTon.H , dType.Tondaten );
					break;
				case "C":
					tmp = new ds_Ton( tmpName , eTon.C , eGrundton.C , eTon.His , eTon.Deses , dType.Tondaten );
					break;
				case "C#":
					tmp = new ds_Ton( tmpName , eTon.Cis , eGrundton.C , eTon.Hisis , eTon.Des , dType.Tondaten );
					break;
				case "C##":
					tmp = new ds_Ton( tmpName , eTon.Cisis , eGrundton.C , eTon.D , eTon.Eses , dType.Tondaten );
					break;
				case "Dbb":
					tmp = new ds_Ton( tmpName , eTon.Deses , eGrundton.D , eTon.His , eTon.C , dType.Tondaten );
					break;
				case "Db":
					tmp = new ds_Ton( tmpName , eTon.Des , eGrundton.D , eTon.Hisis , eTon.Cis , dType.Tondaten );
					break;
				case "D":
					tmp = new ds_Ton( tmpName , eTon.D , eGrundton.D , eTon.Cisis , eTon.Eses , dType.Tondaten );
					break;
				case "D#":
					tmp = new ds_Ton( tmpName , eTon.Dis , eGrundton.D , eTon.Es , eTon.Feses , dType.Tondaten );
					break;
				case "D##":
					tmp = new ds_Ton( tmpName , eTon.Disis , eGrundton.D , eTon.E , eTon.Fes , dType.Tondaten );
					break;
				case "Ebb":
					tmp = new ds_Ton( tmpName , eTon.Eses , eGrundton.E , eTon.Cisis , eTon.D , dType.Tondaten );
					break;
				case "Eb":
					tmp = new ds_Ton( tmpName , eTon.Es , eGrundton.E , eTon.Dis , eTon.Feses , dType.Tondaten );
					break;
				case "E":
					tmp = new ds_Ton( tmpName , eTon.E , eGrundton.E , eTon.Disis , eTon.Fes , dType.Tondaten );
					break;
				case "E#":
					tmp = new ds_Ton( tmpName , eTon.Eis , eGrundton.E , eTon.F , eTon.Geses , dType.Tondaten );
					break;
				case "E##":
					tmp = new ds_Ton( tmpName , eTon.Eisis , eGrundton.E , eTon.Fis , eTon.Ges , dType.Tondaten );
					break;
				case "Fbb":
					tmp = new ds_Ton( tmpName , eTon.Feses , eGrundton.F , eTon.Dis , eTon.Es , dType.Tondaten );
					break;
				case "Fb":
					tmp = new ds_Ton( tmpName , eTon.Fes , eGrundton.F , eTon.Disis , eTon.E , dType.Tondaten );
					break;
				case "F":
					tmp = new ds_Ton( tmpName , eTon.F , eGrundton.F , eTon.Eis , eTon.Geses , dType.Tondaten );
					break;
				case "F#":
					tmp = new ds_Ton( tmpName , eTon.Fis , eGrundton.F , eTon.Eisis , eTon.Ges , dType.Tondaten );
					break;
				case "F##":
					tmp = new ds_Ton( tmpName , eTon.Fisis , eGrundton.F , eTon.G , eTon.Ases , dType.Tondaten );
					break;
				case "Gbb":
					tmp = new ds_Ton( tmpName , eTon.Geses , eGrundton.G , eTon.Eis , eTon.F , dType.Tondaten );
					break;
				case "Gb":
					tmp = new ds_Ton( tmpName , eTon.Ges , eGrundton.G , eTon.Eisis , eTon.Fis , dType.Tondaten );
					break;
				case "G":
					tmp = new ds_Ton( tmpName , eTon.G , eGrundton.G , eTon.Fisis , eTon.Ases , dType.Tondaten );
					break;
				case "G#":
					tmp = new ds_Ton( tmpName , eTon.Gis , eGrundton.G , eTon.As , eTon.As , dType.Tondaten );
					break;
				case "G##":
					tmp = new ds_Ton( tmpName , eTon.Gisis , eGrundton.G , eTon.A , eTon.Heses , dType.Tondaten );
					break;
				case "Abb":
					tmp = new ds_Ton( tmpName , eTon.Ases , eGrundton.A , eTon.Fisis , eTon.G , dType.Tondaten );
					break;
				case "Ab":
					tmp = new ds_Ton( tmpName , eTon.As , eGrundton.A , eTon.Gis , eTon.Gis , dType.Tondaten );
					break;
				case "A":
					tmp = new ds_Ton( tmpName , eTon.A , eGrundton.A , eTon.Gisis , eTon.Heses , dType.Tondaten );
					break;
				case "A#":
					tmp = new ds_Ton( tmpName , eTon.Ais , eGrundton.A , eTon.B , eTon.Ceses , dType.Tondaten );
					break;
				case "A##":
					tmp = new ds_Ton( tmpName , eTon.Aisis , eGrundton.A , eTon.H , eTon.Ces , dType.Tondaten );
					break;
				case "Hbb":
					tmp = new ds_Ton( tmpName , eTon.Heses , eGrundton.H , eTon.Gisis , eTon.A , dType.Tondaten );
					break;
				case "B":
					tmp = new ds_Ton( tmpName , eTon.B , eGrundton.H , eTon.Ais , eTon.Ceses , dType.Tondaten );
					break;
				case "H":
					tmp = new ds_Ton( tmpName , eTon.H , eGrundton.H , eTon.Aisis , eTon.Ces , dType.Tondaten );
					break;
				case "H#":
					tmp = new ds_Ton( tmpName , eTon.His , eGrundton.H , eTon.C , eTon.Deses , dType.Tondaten );
					break;
				case "H##":
					tmp = new ds_Ton( tmpName , eTon.Hisis , eGrundton.H , eTon.Cis , eTon.Des , dType.Tondaten );
					break;
			}

			return tmp;
		}

		#endregion Methoden
	}
}
