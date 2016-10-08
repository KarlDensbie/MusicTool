using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MusicTool;
using MusicTool.Datenbank;

namespace MusicTool.Basisklassen
{
	/// <summary> Klasse       : ds_Ton
	/// <para>ABGELEITET VON: bcl_Basisdaten</para>
	/// DATENSATZ Ton
	/// <para>speichert alle Informationen eines Tons</para>
	/// .
	/// <para>    Programmierer    : Michael Pütz</para>
	/// <para>    getestet am      : </para>
	/// </summary>
	public class ds_Ton:bcl_Basisdaten
	{
		#region VersionInfo

		private static string zz_klassenName= "ds_Ton";
		private static string zz_namespace = "MusicTool.Basisklassen";
		private static dType zz_datenTyp = dType.Tondaten;
		private static string zz_hauptversion= "0";
		private static string zz_nebenversion= "1";
		private static string zz_revision= "1";
		private static string zz_letzteBearbeitung= "2016-07-10  15:23:34";
		private static string zz_ersteBearbeitung= "2016-07-10 13:16.37";
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

		/// <summary>Index des Tons in der Datenbank Töne
		/// <para>TYP: eTon</para>
		/// </summary>
		private eTon _index;

		/// <summary>Grundton des Tons (z.B. "C" oder "D")
		/// <para>TYP: eGrundton</para>
		/// </summary>
		private eGrundton _grundton;

		/// <summary>untere enharmonische Verwechselung des Tons
		/// <para>TYP: eTon</para>
		/// </summary>
		private eTon _enhU;

		/// <summary>obere enharmonische Verwechselung des Tons
		/// <para>TYP: eTon</para>
		/// </summary>
		private eTon _enhO;

		#endregion Attribute

		#region Konstruktor

		/// <summary> Konstruktor(name,tonIndex,grundTon,typ)
		/// <para>Initialisiert den Datensatz mit:</para>
		/// Name, Index, Grundton, enhgarmonischen Verwechselungen und Typ
		/// .
		/// <para>    Programmierer    : Michael Pütz</para>
		///           Version          : 0
		/// <para>    Unterversion     : 1</para>
		///           Revision         : 1
		/// <para>    letzteBearbeitung: 2016-07-10  14:04:13</para>
		/// <para>    ersteBearbeitung : 2016-07-10  13:41:27</para>
		/// .
		/// <para>    getestet am      : </para>
		/// </summary>
		/// <param name="name">Name des Tons, TYP: STRING</param>
		/// <param name="tonIndex">Index des Tons in der Datenbank Töne, TYP: eTon</param>
		/// <param name="grundTon">Grundton des Tons, TYP: eGrundton</param>
		/// <param name="enhU">untere enharmonische Verwechselung des Tons, TYP: eTon</param>
		/// <param name="enhO">obere enharmonische Verwechselung des Tons, TYP: eTon</param>
		/// <param name="typ">Typ des Datensatzes, TYP: dType</param>
		public ds_Ton(string name,eTon tonIndex,eGrundton grundTon, eTon enhU,eTon enhO,dType typ):base(name,"",(int)tonIndex, typ )
		{
			_index = tonIndex;
			_grundton = grundTon;
			_enhU = enhU;
			_enhO = enhO;
		}

		#endregion Konstruktor

		#region Eigenschaften

		/// <summary> Eigenschaft: TonIndex
		/// <para>gibt den Ton-Index aus</para>
		/// <para>TYP: eTon</para>
		/// .
		/// <para>    Programmierer    : Michael Pütz</para>
		///           Version          : 0
		/// <para>    Unterversion     : 1</para>
		///           Revision         : 1
		/// <para>    letzteBearbeitung: 2016-07-10  13:50:42</para>
		/// <para>    ersteBearbeitung : 2016-07-10  13:50:42</para>
		/// .
		/// <para>    getestet am      : </para>
		/// </summary>
		public eTon TonIndex { get { return _index; } }

		/// <summary> Eigenschaft: Grundton
		/// <para>gibt den Grundton aus</para>
		/// <para>TYP: eGrundton</para>
		/// .
		/// <para>    Programmierer    : Michael Pütz</para>
		///           Version          : 0
		/// <para>    Unterversion     : 1</para>
		///           Revision         : 1
		/// <para>    letzteBearbeitung: 2016-07-10  13:51:48</para>
		/// <para>    ersteBearbeitung : 2016-07-10  13:51:48</para>
		/// .
		/// <para>    getestet am      : </para>
		/// </summary>
		public eGrundton Grundton { get { return _grundton; } }

		/// <summary> Eigenschaft: EnhU
		/// <para>gibt die untere enharmonische Verwechselung aus</para>
		/// <para>TYP: eTon</para>
		/// .
		/// <para>    Programmierer    : Michael Pütz</para>
		///           Version          : 0
		/// <para>    Unterversion     : 1</para>
		///           Revision         : 1
		/// <para>    letzteBearbeitung: 2016-07-10  15:19:14</para>
		/// <para>    ersteBearbeitung : 2016-07-10  15:19:14</para>
		/// .
		/// <para>    getestet am      : </para>
		/// </summary>
		public eTon EnhU { get { return _enhU; } }

		/// <summary> Eigenschaft: EnhO
		/// <para>gibt die obere enharmonische Verwechselung aus</para>
		/// <para>TYP: eTon</para>
		/// .
		/// <para>    Programmierer    : Michael Pütz</para>
		///           Version          : 0
		/// <para>    Unterversion     : 1</para>
		///           Revision         : 1
		/// <para>    letzteBearbeitung: 2016-07-10  15:23:10</para>
		/// <para>    ersteBearbeitung : 2016-07-10  15:23:10</para>
		/// .
		/// <para>    getestet am      : </para>
		/// </summary>
		public eTon EnhO { get { return _enhO; } }

		#endregion Eigenschaften
	}
}
