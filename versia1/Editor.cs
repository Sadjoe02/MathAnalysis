using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Web.WebView2.Core;
using System.Globalization;
using Newtonsoft.Json;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using System.Runtime.InteropServices;
using System.Diagnostics;


namespace versia1
{
    public partial class Editor : Form
    {
        private MySqlConnection connection;
        private string connectionString = "server=localhost;uid=root;password=Integral20S0lve24!;database=mathematical_analysis;port=3306;charset=utf8mb4";

        public Editor()
        {
            InitializeComponent();
            Initialize_custom_DropDown(basic_mathematical_symbols, 4, 18, dictionary_basic_symbols);
            Initialize_custom_DropDown_with_sections(greek_letters, dictionary_greek_letters, 6, 15);
            Initialize_custom_DropDown(letterlike_characters, 4, 11, dictionary_letterlike_characters);
            Initialize_custom_DropDown(geometry, 4, 4, dictionary_geometry);
            Initialize_custom_DropDown(relationship_with_denial, 3, 14, dictionary_relationship_with_denial);
            Initialize_custom_DropDown_with_sections(handwritten, dictionary_handwritten, 9, 26);
            Initialize_custom_DropDown(arrows, 4, 19, dictionary_arrows);
            Initialize_custom_DropDown_with_sections(common_operators, dictionary_common_operators, 5, 26);
            Initialize_custom_DropDown(N_ary_operators, 2, 12, dictionary_N_ary_operators);
            Initialize_custom_DropDown_with_sections(difficult_operators, dictionary_difficult_operators, 6, 26);
        }

        public string Type_Input { get; set; }
        public string Name_Lec { get; set; }
        public string Action_Type { get; set; }
        #region Словари
        private Dictionary<string, string> dictionary_basic_symbols = new Dictionary<string, string>
        {
            {"±", "&#177;"},
            {"∞", "&#8734;"},
            {"=", "="},
            {"≠", "&#8800;"},
            {"~", "&#8764;"},
            {"÷", "&#247;"},
            {"!", "!"},
            {"∝", "&#8733;"},
            {"<", "<"},
            {"≪", "&#8810;"},
            {">", ">"},
            {"≫", "&#8811;"},
            {"≤", "&#8804;"},
            {"≥", "&#8805;"},
            {"≅", "&#8773;"},
            {"≈", "&#8776;"},
            {"≡", "&#8801;"},
            {"∀", "&#8704;"},
            {"∁", "&#8705;"},
            {"∂", "&#8706;"},
            {"√", "&#8730;"},
            {"∛", "&#8731;"},
            {"∜", "&#8732;"},
            {"∪", "&#8746;"},
            {"∩", "&#8745;"},
            {"∅", "&#8709;"},
            {"%", "%"},
            {"°", "&#176;"},
            {"℉", "&#8457;"},
            {"℃", "&#8451;"},
            {"∆", "&#8710;"},
            {"∇", "&#8711;"},
            {"∃", "&#8707;"},
            {"∄", "&#8708;"},
            {"∈", "&#8712;"},
            {"∉", "&#8713;"},
            {"∋", "&#8715;"},
            {"∌", "&#8716;"},
            {"←", "&#8592;"},
            {"↑", "&#8593;"},
            {"→", "&#8594;"},
            {"↓", "&#8595;"},
            {"↔", "&#8596;"},
            {"∴", "&#8756;"},
            {"∵", "&#8757;"},
            {"+", "+"},
            {"-", "-"},
            {"α", "&#945;"},
            {"β", "&#946;"},
            {"γ", "&#947;"},
            {"δ", "&#948;"},
            {"ε", "&#949;"},
            {"ϵ", "&#1013;"},
            {"η", "&#951;"},
            {"θ", "&#952;"},
            {"ϑ", "&#977;"},
            {"π", "&#960;"},
            {"ρ", "&#961;"},
            {"σ", "&#963;"},
            {"τ", "&#964;"},
            {"φ", "&#966;"},
            {"ω", "&#969;"},
            {"∗", "&#8727;"},
            {"⋅", "&#8729;"},
            {"⋮", "&#8942;"},
            {"⋯", "&#8943;"},
            {"⋱", "&#8945;"},
            {"ℵ", "&#8501;"},
            {"ℶ", "&#8502;"},
            {"∎", "&#8718;"},
        };

        private Dictionary<string, Dictionary<string, string>> dictionary_greek_letters = new Dictionary<string, Dictionary<string, string>>
        {
            {
                "Строчные", new Dictionary<string, string>
                {
                    {"α", "&#945;"},
                    {"β", "&#946;"},
                    {"γ", "&#947;"},
                    {"δ", "&#948;"},
                    {"ε", "&#949;"},
                    {"ϵ", "&#1013;"},
                    {"ζ", "&#950;"},
                    {"η", "&#951;"},
                    {"θ", "&#952;"},
                    {"ϑ", "&#977;"},
                    {"ι", "&#953;"},
                    {"κ", "&#954;"},
                    {"λ", "&#955;"},
                    {"μ", "&#956;"},
                    {"ν", "&#957;"},
                    {"ξ", "&#958;"},
                    {"ο", "&#959;"},
                    {"π", "&#960;"},
                    {"ϖ", "&#982;"},
                    {"ρ", "&#961;"},
                    {"ϱ", "&#1009;"},
                    {"σ", "&#963;"},
                    {"ϛ", "&#962;"},
                    {"τ", "&#964;"},
                    {"υ", "&#965;"},
                    {"φ", "&#966;"},
                    {"ϕ", "&#981;"},
                    {"χ", "&#967;"},
                    {"ψ", "&#968;"},
                    {"ω", "&#969;"},
                }
            },
            {
                "Прописные", new Dictionary<string, string>
                {
                    {"Α", "&#913;"},
                    {"Β", "&#914;"},
                    {"Γ", "&#915;"},
                    {"∆", "&#916;"},
                    {"Ε", "&#917;"},
                    {"Ζ", "&#918;"},
                    {"Η", "&#919;"},
                    {"Θ", "&#920;"},
                    {"Ι", "&#921;"},
                    {"Κ", "&#922;"},
                    {"Λ", "&#923;"},
                    {"Μ", "&#924;"},
                    {"Ν", "&#925;"},
                    {"Ξ", "&#926;"},
                    {"Ο", "&#927;"},
                    {"Π", "&#928;"},
                    {"Ρ", "&#929;"},
                    {"Σ", "&#931;"},
                    {"Τ", "&#932;"},
                    {"Υ", "&#933;"},
                    {"Φ", "&#934;"},
                    {"Χ", "&#935;"},
                    {"Ψ", "&#936;"},
                    {"Ω", "&#937;"},
                }
            }
        };

        private Dictionary<string, string> dictionary_letterlike_characters = new Dictionary<string, string>
        {
            {"∀", "&#8704;"},
            {"∁", "&#8705;"},
            {"ℂ", "&#8450;"},
            {"∂", "&#8706;"},
            {"ð", "&#240;"},
            {"ℇ", "&#8455;"},
            {"Ϝ", "&#988;"},
            {"ⅎ", "&#8526;"},
            {"ℊ", "&#8458;"},
            {"ℌ", "<span style=\"font-family: 'Cambria Math';\">&#8460;</span>"},
            {"𝓗", "<span style=\"font-family: 'Cambria Math';\">&#8459;</span>"},
            {"ℎ", "&#8462;"},
            {"ℏ", "&#8463;"},
            {"℩", "&#8489;"},
            {"ı", "&#305;"},
            {"ℑ", "&#8465;"},
            {"j", "j"},
            {"ϰ", "&#1008;"},
            {"ℒ", "<span style=\"font-family: 'Cambria Math';\">&#8466;</span>"},
            {"ℓ", "&#8467;"},
            {"ℕ", "&#8469;"},
            {"℘", "&#8472;"},
            {"ℚ", "&#8474;"},
            {"ℛ", "<span style=\"font-family: 'Cambria Math';\">&#8475;</span>"},
            {"ℜ", "&#8476;"},
            {"ℝ", "&#8477;"},
            {"ℤ", "&#8484;"},
            {"℧", "℧"},
            {"Å", "&#8491;"},
            {"ℬ", "<span style=\"font-family: 'Cambria Math';\">&#8492;</span>"},
            {"℮", "&#8494;"},
            {"ℰ", "<span style=\"font-family: 'Cambria Math';\">&#8496;</span>"},
            {"∃", "&#8707;"},
            {"∄", "&#8708;"},
            {"ℱ", "<span style=\"font-family: 'Cambria Math';\">&#8497;</span>"},
            {"ℳ", "<span style=\"font-family: 'Cambria Math';\">&#8499;</span>"},
            {"ℵ", "&#8501;"},
            {"ℶ", "&#8502;"},
            {"ℸ", "&#8504;"},
        };

        private Dictionary<string, string> dictionary_geometry = new Dictionary<string, string>
        {
            {"∟", "&#8735;"},
            {"∠", "&#8736;"},
            {"∡", "&#8737;"},
            {"∢", "&#8738;"},
            {"⊾", "&#8894;"},
            {"⊿", "⊿"},
            {"⋕", "&#8917;"},
            {"⟂", "&#10178;"},
            {"∤", "&#8740;"},
            {"∥", "&#8741;"},
            {"∦", "&#8742;"},
            {"∶", "&#8758;"},
            {"∷", "&#8759;"},
            {"∴", "&#8756;"},
            {"∵", "&#8757;"},
            {"∎", "&#8718;"},
        };

        private Dictionary<string, string> dictionary_relationship_with_denial = new Dictionary<string, string>
        {
            {"≠", "&#8800;"},
            {"≮", "<span style=\"font-family: 'Cambria Math';\">&#8814;</span>"},
            {"≯", "<span style=\"font-family: 'Cambria Math';\">&#8815;</span>"},
            {"≰", "<span style=\"font-family: 'Cambria Math';\">&#8816;</span>"},
            {"≱", "<span style=\"font-family: 'Cambria Math';\">&#8817;</span>"},
            {"≢", "<span style=\"font-family: 'Cambria Math';\">&#8802;</span>"},
            {"≁", "&#8769;"},
            {"≄", "&#8772;"},
            {"≉", "<span style=\"font-family: 'Cambria Math';\">&#8777;</span>"},
            {"≇", "&#8775;"},
            {"≭", "&#8813;"},
            {"≨", "&#8808;"},
            {"≩", "&#8809;"},
            {"⊀", "&#8832;"},
            {"⊁", "&#8833;"},
            {"⋠", "&#8928;"},
            {"⋡", "&#8929;"},
            {"∉", "&#8713;"},
            {"∌", "&#8716;"},
            {"⊄", "&#8836;"},
            {"⊅", "&#8837;"},
            {"⊈", "&#8840;"},
            {"⊉", "&#8841;"},
            {"⊊", "&#8842;"},
            {"⊋", "&#8843;"},
            {"⋢", "&#8930;"},
            {"⋣", "&#8931;"},
            {"⋦", "&#8820;"},
            {"⋧", "&#8821;"},
            {"⋨", "&#8936;"},
            {"⋩", "&#8937;"},
            {"⋪", "&#8938;"},
            {"⋫", "&#8939;"},
            {"⋬", "&#8940;"},
            {"⋭", "&#8941;"},
            {"∤", "&#8740;"},
            {"∦", "&#8742;"},
            {"⊬", "&#8876;"},
            {"⊭", "&#8877;"},
            {"⊮", "&#8878;"},
            {"⊯", "&#8879;"},
            {"∄", "&#8708;"},
        };

        private Dictionary<string, Dictionary<string, string>> dictionary_handwritten = new Dictionary<string, Dictionary<string, string>>
        {
            {
                "Рукописные", new Dictionary<string, string>
                {
                    {"𝓐", "<span style=\"font-family: 'Cambria Math';\">&#119964;</span>"},
                    {"𝓑", "<span style=\"font-family: 'Cambria Math';\">&#8492;</span>"},
                    {"𝓒", "<span style=\"font-family: 'Cambria Math';\">&#119966;</span>"},
                    {"𝓓", "<span style=\"font-family: 'Cambria Math';\">&#119967;</span>"},
                    {"𝓔", "<span style=\"font-family: 'Cambria Math';\">&#8496;</span>"},
                    {"𝓕", "<span style=\"font-family: 'Cambria Math';\">&#8497;</span>"},
                    {"𝓖", "<span style=\"font-family: 'Cambria Math';\">&#119970;</span>"},
                    {"𝓗", "<span style=\"font-family: 'Cambria Math';\">&#8459;</span>"},
                    {"𝓘", "<span style=\"font-family: 'Cambria Math';\">&#8464;</span>"},
                    {"𝓙", "<span style=\"font-family: 'Cambria Math';\">&#119973;</span>"},
                    {"𝓚", "<span style=\"font-family: 'Cambria Math';\">&#119974;</span>"},
                    {"𝓛", "<span style=\"font-family: 'Cambria Math';\">&#8466;</span>"},
                    {"𝓜", "<span style=\"font-family: 'Cambria Math';\">&#8499;</span>"},
                    {"𝓝", "<span style=\"font-family: 'Cambria Math';\">&#119977;</span>"},
                    {"𝓞", "<span style=\"font-family: 'Cambria Math';\">&#119978;</span>"},
                    {"𝓟", "<span style=\"font-family: 'Cambria Math';\">&#119979;</span>"},
                    {"𝓠", "<span style=\"font-family: 'Cambria Math';\">&#119980;</span>"},
                    {"𝓡", "<span style=\"font-family: 'Cambria Math';\">&#8475;</span>"},
                    {"𝓢", "<span style=\"font-family: 'Cambria Math';\">&#119982;</span>"},
                    {"𝓣", "<span style=\"font-family: 'Cambria Math';\">&#119983;</span>"},
                    {"𝓤", "<span style=\"font-family: 'Cambria Math';\">&#119984;</span>"},
                    {"𝓥", "<span style=\"font-family: 'Cambria Math';\">&#119985;</span>"},
                    {"𝓦", "<span style=\"font-family: 'Cambria Math';\">&#119986;</span>"},
                    {"𝓧", "<span style=\"font-family: 'Cambria Math';\">&#119987;</span>"},
                    {"𝓨", "<span style=\"font-family: 'Cambria Math';\">&#119988;</span>"},
                    {"𝓩", "<span style=\"font-family: 'Cambria Math';\">&#119989;</span>"},
                    {"𝓪", "<span style=\"font-family: 'Cambria Math';\">&#119990;</span>"},
                    {"𝓫", "<span style=\"font-family: 'Cambria Math';\">&#119991;</span>"},
                    {"𝓬", "<span style=\"font-family: 'Cambria Math';\">&#119992;</span>"},
                    {"𝓭", "<span style=\"font-family: 'Cambria Math';\">&#119993;</span>"},
                    {"𝓮", "<span style=\"font-family: 'Cambria Math';\">&#8495;</span>"},
                    {"𝓯", "<span style=\"font-family: 'Cambria Math';\">&#119995;</span>"},
                    {"𝓰", "<span style=\"font-family: 'Cambria Math';\">&#8458;</span>"},
                    {"𝓱", "<span style=\"font-family: 'Cambria Math';\">&#119997;</span>"},
                    {"𝓲", "<span style=\"font-family: 'Cambria Math';\">&#119998;</span>"},
                    {"𝓳", "<span style=\"font-family: 'Cambria Math';\">&#119999;</span>"},
                    {"𝓴", "<span style=\"font-family: 'Cambria Math';\">&#120000;</span>"},
                    {"𝓵", "<span style=\"font-family: 'Cambria Math';\">&#120001;</span>"},
                    {"𝓶", "<span style=\"font-family: 'Cambria Math';\">&#120002;</span>"},
                    {"𝓷", "<span style=\"font-family: 'Cambria Math';\">&#120003;</span>"},
                    {"𝓸", "<span style=\"font-family: 'Cambria Math';\">&#8500;</span>"},
                    {"𝓹", "<span style=\"font-family: 'Cambria Math';\">&#120005;</span>"},
                    {"𝓺", "<span style=\"font-family: 'Cambria Math';\">&#120006;</span>"},
                    {"𝓻", "<span style=\"font-family: 'Cambria Math';\">&#120007;</span>"},
                    {"𝓼", "<span style=\"font-family: 'Cambria Math';\">&#120008;</span>"},
                    {"𝓽", "<span style=\"font-family: 'Cambria Math';\">&#120009;</span>"},
                    {"𝓾", "<span style=\"font-family: 'Cambria Math';\">&#120010;</span>"},
                    {"𝓿", "<span style=\"font-family: 'Cambria Math';\">&#120011;</span>"},
                    {"𝔀", "<span style=\"font-family: 'Cambria Math';\">&#120012;</span>"},
                    {"𝔁", "<span style=\"font-family: 'Cambria Math';\">&#120013;</span>"},
                    {"𝔂", "<span style=\"font-family: 'Cambria Math';\">&#120014;</span>"},
                    {"𝔃", "<span style=\"font-family: 'Cambria Math';\">&#120015;</span>"},
                }
            },
            {
                "Готические", new Dictionary<string, string>
                {
                    {"𝔄", "<span style=\"font-family: 'Cambria Math';\">&#120068;</span>"},
                    {"𝔅", "<span style=\"font-family: 'Cambria Math';\">&#120069;</span>"},
                    {"ℭ", "<span style=\"font-family: 'Cambria Math';\">&#8493;</span>"},
                    {"𝔇", "<span style=\"font-family: 'Cambria Math';\">&#120071;</span>"},
                    {"𝔈", "<span style=\"font-family: 'Cambria Math';\">&#120072;</span>"},
                    {"𝔉", "<span style=\"font-family: 'Cambria Math';\">&#120073;</span>"},
                    {"𝔊", "<span style=\"font-family: 'Cambria Math';\">&#120074;</span>"},
                    {"ℌ", "<span style=\"font-family: 'Cambria Math';\">&#8460;</span>"},
                    {"𝕴", "<span style=\"font-family: 'Cambria Math';\">&#8465;</span>"},
                    {"𝔍", "<span style=\"font-family: 'Cambria Math';\">&#120077;</span>"},
                    {"𝔎", "<span style=\"font-family: 'Cambria Math';\">&#120078;</span>"},
                    {"𝔏", "<span style=\"font-family: 'Cambria Math';\">&#120079;</span>"},
                    {"𝔐", "<span style=\"font-family: 'Cambria Math';\">&#120080;</span>"},
                    {"𝔑", "<span style=\"font-family: 'Cambria Math';\">&#120081;</span>"},
                    {"𝔒", "<span style=\"font-family: 'Cambria Math';\">&#120082;</span>"},
                    {"𝔓", "<span style=\"font-family: 'Cambria Math';\">&#120083;</span>"},
                    {"𝔔", "<span style=\"font-family: 'Cambria Math';\">&#120084;</span>"},
                    {"𝕽", "<span style=\"font-family: 'Cambria Math';\">&#8476;</span>"},
                    {"𝔖", "<span style=\"font-family: 'Cambria Math';\">&#120086;</span>"},
                    {"𝔗", "<span style=\"font-family: 'Cambria Math';\">&#120087;</span>"},
                    {"𝔘", "<span style=\"font-family: 'Cambria Math';\">&#120088;</span>"},
                    {"𝔙", "<span style=\"font-family: 'Cambria Math';\">&#120089;</span>"},
                    {"𝔚", "<span style=\"font-family: 'Cambria Math';\">&#120090;</span>"},
                    {"𝔛", "<span style=\"font-family: 'Cambria Math';\">&#120091;</span>"},
                    {"𝔜", "<span style=\"font-family: 'Cambria Math';\">&#120092;</span>"},
                    {"ℨ", "<span style=\"font-family: 'Cambria Math';\">&#8488;</span>"},
                    {"𝔞", "<span style=\"font-family: 'Cambria Math';\">&#120094;</span>"},
                    {"𝔟", "<span style=\"font-family: 'Cambria Math';\">&#120095;</span>"},
                    {"𝔠", "<span style=\"font-family: 'Cambria Math';\">&#120096;</span>"},
                    {"𝔡", "<span style=\"font-family: 'Cambria Math';\">&#120097;</span>"},
                    {"𝔢", "<span style=\"font-family: 'Cambria Math';\">&#120098;</span>"},
                    {"𝔣", "<span style=\"font-family: 'Cambria Math';\">&#120099;</span>"},
                    {"𝔤", "<span style=\"font-family: 'Cambria Math';\">&#120100;</span>"},
                    {"𝔥", "<span style=\"font-family: 'Cambria Math';\">&#120101;</span>"},
                    {"𝔦", "<span style=\"font-family: 'Cambria Math';\">&#120102;</span>"},
                    {"𝔧", "<span style=\"font-family: 'Cambria Math';\">&#120103;</span>"},
                    {"𝔨", "<span style=\"font-family: 'Cambria Math';\">&#120104;</span>"},
                    {"𝔩", "<span style=\"font-family: 'Cambria Math';\">&#120105;</span>"},
                    {"𝔪", "<span style=\"font-family: 'Cambria Math';\">&#120106;</span>"},
                    {"𝔫", "<span style=\"font-family: 'Cambria Math';\">&#120107;</span>"},
                    {"𝔬", "<span style=\"font-family: 'Cambria Math';\">&#120108;</span>"},
                    {"𝔭", "<span style=\"font-family: 'Cambria Math';\">&#120109;</span>"},
                    {"𝔮", "<span style=\"font-family: 'Cambria Math';\">&#120110;</span>"},
                    {"𝔯", "<span style=\"font-family: 'Cambria Math';\">&#120111;</span>"},
                    {"𝔰", "<span style=\"font-family: 'Cambria Math';\">&#120112;</span>"},
                    {"𝔱", "<span style=\"font-family: 'Cambria Math';\">&#120113;</span>"},
                    {"𝔲", "<span style=\"font-family: 'Cambria Math';\">&#120114;</span>"},
                    {"𝔳", "<span style=\"font-family: 'Cambria Math';\">&#120115;</span>"},
                    {"𝔴", "<span style=\"font-family: 'Cambria Math';\">&#120116;</span>"},
                    {"𝔵", "<span style=\"font-family: 'Cambria Math';\">&#120117;</span>"},
                    {"𝔶", "<span style=\"font-family: 'Cambria Math';\">&#120118;</span>"},
                    {"𝔷", "<span style=\"font-family: 'Cambria Math';\">&#120119;</span>"},
                }
            },
            { 
                "Ажурные", new Dictionary<string, string>
                { 
                    {"𝔸", "&#120120;"},
                    {"𝔹", "&#120121;"},
                    {"ℂ", "&#8450;"},
                    {"𝔻", "&#120123;"},
                    {"𝔼", "&#120124;"},
                    {"𝔽", "&#120125;"},
                    {"𝔾", "&#120126;"},
                    {"ℍ", "&#8461;"},
                    {"𝕀", "&#120128;"},
                    {"𝕁", "&#120129;"},
                    {"𝕂", "&#120130;"},
                    {"𝕃", "&#120131;"},
                    {"𝕄", "&#120132;"},
                    {"ℕ", "&#8469;"},
                    {"𝕆", "&#120134;"},
                    {"ℙ", "&#8473;"},
                    {"ℚ", "&#8474;"},
                    {"ℝ", "&#8477;"},
                    {"𝕊", "&#120138;"},
                    {"𝕋", "&#120139;"},
                    {"𝕌", "&#120140;"},
                    {"𝕍", "&#120141;"},
                    {"𝕎", "&#120142;"},
                    {"𝕏", "&#120143;"},
                    {"𝕐", "&#120144;"},
                    {"ℤ", "&#8484;"},
                    {"𝕒", "&#120146;"},
                    {"𝕓", "&#120147;"},
                    {"𝕔", "&#120148;"},
                    {"𝕕", "&#120149;"},
                    {"𝕖", "&#120150;"},
                    {"𝕗", "&#120151;"},
                    {"𝕘", "&#120152;"},
                    {"𝕙", "&#120153;"},
                    {"𝕚", "&#120154;"},
                    {"𝕛", "&#120155;"},
                    {"𝕜", "&#120156;"},
                    {"𝕝", "&#120157;"},
                    {"𝕞", "&#120158;"},
                    {"𝕟", "&#120159;"},
                    {"𝕠", "&#120160;"},
                    {"𝕡", "&#120161;"},
                    {"𝕢", "&#120162;"},
                    {"𝕣", "&#120163;"},
                    {"𝕤", "&#120164;"},
                    {"𝕥", "&#120165;"},
                    {"𝕦", "&#120166;"},
                    {"𝕧", "&#120167;"},
                    {"𝕨", "&#120168;"},
                    {"𝕩", "&#120169;"},
                    {"𝕪", "&#120170;"},
                    {"𝕫", "&#120171;"},
                }
            }
        };

        private Dictionary<string, string> dictionary_arrows = new Dictionary<string, string>
        {
            {"←", "&#8592;"},
            {"↑", "&#8593;"},
            {"→", "&#8594;"},
            {"↓", "&#8595;"},
            {"↔", "&#8596;"},
            {"↕", "&#8597;"},
            {"⇐", "&#8656;"},
            {"⇒", "&#8658;"},
            {"⇑", "&#8657;"},
            {"⇓", "&#8659;"},
            {"⇔", "&#8660;"},
            {"⇕", "&#8661;"},
            {"⟵", "&#10229;"},
            {"⟶", "&#10230;"},
            {"⟷", "&#10231;"},
            {"⟸", "&#10232;"},
            {"⟹", "&#10233;"},
            {"⟺", "&#10234;"},
            {"↗", "↗"},
            {"↖", "↖"},
            {"↘", "↘"},
            {"↙", "↙"},
            {"↚", "<span style=\"font-family: 'Cambria Math';\">&#8602;</span>"},
            {"↛", "<span style=\"font-family: 'Cambria Math';\">&#8603;</span>"},
            {"↮", "<span style=\"font-family: 'Cambria Math';\">&#8622;</span>"},
            {"⇍", "&#8653;"},
            {"⇏", "&#8655;"},
            {"⇎", "&#8654;"},
            {"⇠", "&#8672;"},
            {"⇢", "&#8674;"},
            {"↤", "&#8612;"},
            {"↦", "&#8614;"},
            {"⟻", "&#10235;"},
            {"⟼", "&#10236;"},
            {"↩", "&#8617;"},
            {"↪", "&#8618;"},
            {"↼", "&#8636;"},
            {"↽", "&#8637;"},
            {"⇀", "&#8640;"},
            {"⇁", "&#8641;"},
            {"↿", "&#8639;"},
            {"↾", "&#8638;"},
            {"⇃", "&#8643;"},
            {"⇂", "&#8642;"},
            {"⇋", "&#8651;"},
            {"⇌", "&#8652;"},
            {"⇇", "&#8647;"},
            {"⇉", "&#8649;"},
            {"⇈", "&#8648;"},
            {"⇊", "&#8650;"},
            {"⇆", "&#8646;"},
            {"⇄", "&#8644;"},
            {"↫", "&#8619;"},
            {"↬", "&#8620;"},
            {"↢", "&#8610;"},
            {"↣", "&#8611;"},
            {"↰", "&#8624;"},
            {"↱", "&#8625;"},
            {"↲", "&#8626;"},
            {"↳", "&#8627;"},
            {"⇚", "&#8666;"},
            {"⇛", "&#8667;"},
            {"↞", "&#8606;"},
            {"↠", "&#8608;"},
            {"↶", "&#8630;"},
            {"↷", "&#8631;"},
            {"⭯", "&#11119;"},
            {"⭮", "&#11118;"},
            {"⊸", "&#8888;"},
            {"↭", "&#8621;"},
            {"↜", "&#8604;"},
            {"↝", "&#8605;"},
            {"⇜", "&#8668;"},
            {"⇝", "&#8669;"},
        };

        private Dictionary<string, Dictionary<string, string>> dictionary_common_operators = new Dictionary<string, Dictionary<string, string>>
        {
            {
                "Бинарные операторы", new Dictionary<string, string>
                {
                    {"+", "+"},
                    {"-", "-"},
                    {"÷", "&#247;"},
                    {"×", "&#215;"},
                    {"±", "&#177;"},
                    {"∓", "&#8723;"},
                    {"∝", "&#8733;"},
                    {"/", "/"},
                    {"∗", "&#8727;"},
                    {"∘", "&#8728;"},
                    {"∙", "&#8729;"},
                    {"·", "&#183;"},
                    {"∪", "&#8746;"},
                    {"∩", "&#8745;"},
                    {"⊎", "&#8846;"},
                    {"⊓", "&#8851;"},
                    {"⊔", "&#8852;"},
                    {"⋀", "&#8743;"},
                    {"⋁", "&#8744;"},
                }
            },
            {
                "Реляционные операторы", new Dictionary<string, string>
                {
                    {"=", "="},
                    {"≠", "&#8800;"},
                    {"<", "<"},
                    {">", ">"},
                    {"≤", "&#8804;"},
                    {"≥", "&#8805;"},
                    {"≮", "<span style=\"font-family: 'Cambria Math';\">&#8814;</span>"},
                    {"≯", "<span style=\"font-family: 'Cambria Math';\">&#8815;</span>"},
                    {"≰", "<span style=\"font-family: 'Cambria Math';\">&#8816;</span>"},
                    {"≱", "<span style=\"font-family: 'Cambria Math';\">&#8817;</span>"},
                    {"≡", "&#8801;"},
                    {"~", "&#8764;"},
                    {"≃", "&#8771;"},
                    {"≈", "&#8776;"},
                    {"≢", "<span style=\"font-family: 'Cambria Math';\">&#8802;</span>"},
                    {"≄", "&#8772;"},
                    {"≉", "<span style=\"font-family: 'Cambria Math';\">&#8777;</span>"},
                    {"≇", "&#8775;"},
                    {"∝", "&#8733;"},
                    {"≪", "&#8810;"},
                    {"≫", "&#8811;"},
                    {"∈", "&#8712;"},
                    {"∉", "&#8713;"},
                    {"∋", "&#8715;"},
                    {"∌", "&#8716;"},
                    {"⊂", "&#8834;"},
                    {"⊃", "&#8835;"},
                    {"⊆", "&#8838;"},
                    {"⊇", "&#8839;"},
                    {"⊄", "&#8836;"},
                    {"⊅", "&#8837;"},
                    {"⊈", "&#8840;"},
                    {"⊉", "&#8841;"},
                    {"≺", "&#8826;"},
                    {"≻", "&#8827;"},
                    {"≼", "&#8828;"},
                    {"≽", "&#8829;"},
                    {"⊀", "&#8832;"},
                    {"⊁", "&#8833;"},
                    {"⋠", "&#8928;"},
                    {"⋡", "&#8929;"},
                    {"⊏", "&#8847;"},
                    {"⊐", "&#8848;"},
                    {"⊑", "&#8849;"},
                    {"⊒", "&#8850;"},
                    {"∥", "&#8741;"},
                    {"∦", "&#8742;"},
                    {"⟂", "&#10178;"},
                    {"⊢", "&#8866;"},
                    {"⊣", "&#8867;"},
                    {"⋈", "&#8904;"},
                    {"≍", "&#8781;"},
                }
            }
        };

        private Dictionary<string, string> dictionary_N_ary_operators = new Dictionary<string, string>
        {
            {"∑", "&#8721;"},
            {"∫", "&#8747;"},
            {"∬", "&#8748;"},
            {"∭", "&#8749;"},
            {"∮", "&#8750;"},
            {"∯", "&#8751;"},
            {"∰", "&#8752;"},
            {"∱", "&#8753;"},
            {"∲", "&#8754;"},
            {"∳", "&#8755;"},
            {"∏", "&#8719;"},
            {"∐", "&#8720;"},
            {"⋂", "&#8898;"},
            {"⋃", "&#8899;"},
            {"⋀", "&#8896;"},
            {"⋁", "&#8897;"},
            {"⨃", "&#10755;"},
            {"⨄", "&#10756;"},
            {"⨂", "&#10754;"},
            {"⨁", "&#10753;"},
            {"⨀", "&#10752;"},
        };

        private Dictionary<string, Dictionary<string, string>> dictionary_difficult_operators = new Dictionary<string, Dictionary<string, string>>
        {
            {
                "Бинарные операторы", new Dictionary<string, string>
                {
                    {"∔", "&#8724;"},
                    {"∸", "&#8760;"},
                    {"∖", "&#8726;"},
                    {"⋒", "&#8914;"},
                    {"⋓", "&#8915;"},
                    {"⊟", "&#8863;"},
                    {"⊠", "&#8864;"},
                    {"⊡", "&#8865;"},
                    {"⊞", "&#8862;"},
                    {"⋇", "&#8903;"},
                    {"⋉", "&#8905;"},
                    {"⋊", "&#8906;"},
                    {"⋋", "&#8907;"},
                    {"⋌", "&#8908;"},
                    {"⋏", "&#8911;"},
                    {"⋎", "&#8910;"},
                    {"⊝", "&#8861;"},
                    {"⊺", "&#8890;"},
                    {"⊕", "&#8853;"},
                    {"⊖", "&#8854;"},
                    {"⊗", "&#8855;"},
                    {"⊘", "&#8856;"},
                    {"⊙", "&#8857;"},
                    {"⊛", "&#8859;"},
                    {"⊚", "&#8858;"},
                    {"†", "&#8224;"},
                    {"‡", "&#8225;"},
                    {"⋆", "&#8902;"},
                    {"⋄", "&#8900;"},
                    {"≀", "&#8768;"},
                    {"△", "&#9651;"},
                    {"⋀", "&#8896;"},
                    {"⋁", "&#8897;"},
                    {"⨂", "&#10754;"},
                    {"⨁", "&#10753;"},
                    {"⨀", "&#10752;"},
                    {"⨃", "&#10755;"},
                    {"⨄", "&#10756;"},
                    {"⨅", "&#10757;"},
                    {"⨆", "&#10758;"},
                }
            },
            {
                "Реляционные операторы", new Dictionary<string, string>
                {
                    {"∴", "&#8756;"},
                    {"∵", "&#8757;"},
                    {"⋘", "&#8920;"},
                    {"⋙", "&#8921;"},
                    {"≦", "&#8806;"},
                    {"≧", "&#8807;"},
                    {"≲", "&#8818;"},
                    {"≳", "&#8819;"},
                    {"⋖", "&#8918;"},
                    {"⋗", "&#8919;"},
                    {"⋚", "&#8922;"},
                    {"⋛", "&#8923;"},
                    {"≶", "&#8822;"},
                    {"≷", "&#8823;"},
                    {"≑", "&#8785;"},
                    {"≒", "&#8786;"},
                    {"≓", "&#8787;"},
                    {"∽", "&#8765;"},
                    {"≊", "&#8778;"},
                    {"≃", "&#8771;"},
                    {"≼", "&#8828;"},
                    {"≽", "&#8829;"},
                    {"≾", "&#8830;"},
                    {"≿", "&#8831;"},
                    {"⋜", "&#8924;"},
                    {"⋝", "&#8925;"},
                    {"⊆", "&#8838;"},
                    {"⊇", "&#8839;"},
                    {"⊲", "&#8882;"},
                    {"⊳", "&#8883;"},
                    {"⊴", "&#8884;"},
                    {"⊵", "&#8885;"},
                    {"⊨", "&#8872;"},
                    {"⋐", "&#8912;"},
                    {"⋑", "&#8913;"},
                    {"⊏", "&#8847;"},
                    {"⊐", "&#8848;"},
                    {"⊑", "&#8849;"},
                    {"⊒", "&#8850;"},
                    {"⊩", "&#8873;"},
                    {"⊪", "&#8874;"},
                    {"≖", "&#8790;"},
                    {"≗", "&#8791;"},
                    {"≜", "&#8796;"},
                    {"≏", "&#8783;"},
                    {"≎", "&#8782;"},
                    {"∝", "&#8733;"},
                    {"≬", "&#8812;"},
                    {"⋔", "&#8916;"},
                    {"≐", "&#8784;"},
                    {"⋈", "&#8904;"},
                }
            }
        };

        #endregion

        private void Initialize_custom_DropDown(ToolStripDropDownButton dropdownButton, int rows, int columns, Dictionary<string, string> symbols)
        {
            TableLayoutPanel tableLayoutPanel = new TableLayoutPanel
            {
                AutoSize = true,
                ColumnCount = columns,
                RowCount = rows,
                GrowStyle = TableLayoutPanelGrowStyle.FixedSize
            };
            tableLayoutPanel.ColumnStyles.Clear();
            tableLayoutPanel.RowStyles.Clear();
            for (int i = 0; i < columns; i++)
            {
                tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 25));
            }

            for (int i = 0; i < rows; i++)
            {
                tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 25));
            }
            int symbol_index = 0;
            foreach (KeyValuePair<string, string> symbol in symbols)
            {
                var symbol_Button = new Button
                {
                    Text = symbol.Key,
                    Dock = DockStyle.Fill,
                    Margin = new Padding(0),
                    Padding = new Padding(0),
                    Font = new Font("Cambria", 12),
                    Tag = symbol.Value

                };
                symbol_Button.Click += symbol_button_Click;

                int row = symbol_index / columns;
                int column = symbol_index % columns;
                tableLayoutPanel.Controls.Add(symbol_Button, column, row);

                symbol_index++;
                if (symbol_index >= rows * columns) break; 
            }
            ToolStripControlHost controlHost = new ToolStripControlHost(tableLayoutPanel);
            ToolStripDropDown dropDown = new ToolStripDropDown();
            dropDown.Items.Add(controlHost);

            dropdownButton.DropDown = dropDown;
        }

        private void symbol_button_Click(object sender, EventArgs e)
        {
            var button = sender as Button;
            if (button != null && button.Tag is string html_code)
            {
                string current_font = "Times New Roman";
                int current_size = 14;

                string styled_html = $"<span style=\"font-family: '{current_font}'; font-size: {current_size}pt;\">{html_code}</span>";
                string escaped_html_code = System.Web.HttpUtility.JavaScriptStringEncode(styled_html);

                string insert_html_script = $"document.execCommand('insertHTML', false, \"{escaped_html_code}\"); document.body.focus();";
                field_drive.CoreWebView2.ExecuteScriptAsync(insert_html_script);
                field_drive.Focus();
            }
        }

        private void Initialize_custom_DropDown_with_sections(ToolStripDropDownButton dropdownButton, Dictionary<string, Dictionary<string, string>> groupedSymbols, int rows, int columns)
        {
            TableLayoutPanel tableLayoutPanel = new TableLayoutPanel
            {
                AutoSize = true,
                ColumnCount = columns,
                RowCount = rows,
                GrowStyle = TableLayoutPanelGrowStyle.FixedSize
            };

            tableLayoutPanel.ColumnStyles.Clear();
            tableLayoutPanel.RowStyles.Clear();
            for (int i = 0; i < columns; i++)
            {
                tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 25));
            }

            for (int i = 0; i < rows; i++)
            {
                tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 25));
            }

            foreach (var group in groupedSymbols)
            {
                Label header = new Label
                {
                    Text = group.Key,
                    Dock = DockStyle.Fill,
                    TextAlign = ContentAlignment.MiddleLeft,
                    Margin = new Padding(0),
                    Padding = new Padding(0),
                    Font = new Font("Times New Roman", 12)
                };
                tableLayoutPanel.Controls.Add(header);
                tableLayoutPanel.SetColumnSpan(header, tableLayoutPanel.ColumnCount); 
                foreach (var symbol in group.Value)
                {
                    var symbol_Button = new Button
                    {
                        Text = symbol.Key,
                        Dock = DockStyle.Fill,
                        Margin = new Padding(0),
                        Padding = new Padding(0),
                        Font = new Font("Cambria", 12),
                        Tag = symbol.Value
                    };

                    symbol_Button.Click += symbol_button_with_sections_Click;
                    tableLayoutPanel.Controls.Add(symbol_Button);

                }
            }
            ToolStripControlHost controlHost = new ToolStripControlHost(tableLayoutPanel);
            ToolStripDropDown dropDown = new ToolStripDropDown();
            dropDown.Items.Add(controlHost);
            dropdownButton.DropDown = dropDown;
        }

        private void symbol_button_with_sections_Click(object sender, EventArgs e)
        {
            var button = sender as Button;
            if (button != null && button.Tag is string html_code)
            {
                string current_font = "Times New Roman";
                int current_size = 14; 

                string styled_html = $"<span style=\"font-family: '{current_font}'; font-size: {current_size}pt;\">{html_code}</span>";
                string escaped_html_code = System.Web.HttpUtility.JavaScriptStringEncode(styled_html);

                string insert_html_script = $"document.execCommand('insertHTML', false, \"{escaped_html_code}\"); document.body.focus();";
                field_drive.CoreWebView2.ExecuteScriptAsync(insert_html_script);
                field_drive.Focus();
            }
        }


        private async void Editor_Load(object sender, EventArgs e)
        { 
            try
            {
                await SetEditableContentInWebView(field_drive);
                string script = @"
            document.body.style.fontFamily = 'Times New Roman';
            document.body.style.fontSize = '14pt';
            document.body.style.color = 'black'";

                Apply_Script(script);
                await initialization_additional_scripts();
                field_drive.Focus();
                hint.AutoPopDelay = 5000;  // Время отображения в миллисекундах, 5000 мс = 5 секунд
                hint.InitialDelay = 1000;  // Задержка перед показом подсказки
                hint.ReshowDelay = 500;    // Задержка перед повторным показом подсказки
                hint.ShowAlways = true;     // Показывать подсказку всегда, даже если форма не активна

                hint.SetToolTip(this.bold_shrift, "Полужирный (Ctrl+B или Ctrl+Shift+B)\nПрименение полужирного\nначертания к тексту");
                hint.SetToolTip(this.italicy_shrift, "Курсив (Ctrl+I или Ctrl+Shift+I)\nПрименение курсивного\nначертания к тексту");
                hint.SetToolTip(this.underlined_shrift, "Подчеркнутый (Ctrl+U или Ctrl+Shift+U)\nПодчеркивание текста");
                hint.SetToolTip(this.striked_shrift, "Зачеркнутый (Ctrl+Shift+S)\nЗачеркивание текста линией");
                hint.SetToolTip(this.lower_index, "Подстрочный (Ctrl+L)\nВвод маленьких букв ниже\nопорной линии текста");
                hint.SetToolTip(this.top_index, "Надстрочный (Ctrl+T)\nВвод маленьких букв выше\nопорной линии текста");
                hint.SetToolTip(this.markers, "Маркеры (Ctrl+Shift+M)\nСоздание маркированного списка");
                hint.SetToolTip(this.numbered_list, "Нумерация (Ctrl+Shift+N)\nСоздание нумерованного списка");
                hint.SetToolTip(this.reduce_indentation, "Уменьшить отступ (Ctrl+Shift+R)\nУменьшение расстояния от\nполя до абзаца");
                hint.SetToolTip(this.increase_indentation, "Увеличить отступ (Ctrl+Shift+A)\nУвеличение расстояния от\nполя до абзаца");
                hint.SetToolTip(this.left_alignment, "Выровнять по левому краю (Ctrl+Shift+L)\nВыравнивание соержимого по\nлевому краю");
                hint.SetToolTip(this.center_alignment, "Выровнять по центру (Ctrl+E)\nВыравнивание соержимого по\nцентру страницы");
                hint.SetToolTip(this.right_alignment, "Выровнять по правому краю (Ctrl+R)\nВыравнивание соержимого по\nправому краю");
                hint.SetToolTip(this.width_alignment, "Выровнять по ширине (Ctrl+J)\nРавномерное распределение текста\nмежду левым и правым полями");
                hint.SetToolTip(this.undo, "Повторить ввод (Ctrl+Y или Ctrl+Shift+Y)");
                hint.SetToolTip(this.redo, "Отменить ввод (Ctrl+Z или Ctrl+Shift+Z)");
                hint.SetToolTip(this.highlighting_color, "Цвет выделени текста\nВыделение текста цветом");
                hint.SetToolTip(this.font_color, "Цвет текста\nИзменение цвета текста");
                hint.SetToolTip(this.fonts, "Шрифт\nВыбор нового шрифта\nдля текста");
                hint.SetToolTip(this.font_size, "Размер шрифта\nИзменение размера текста\nДля ввода собственного значения\nвведите его и нажмите Enter");
                hint.SetToolTip(this.style, "Стили\nВыбор стиля текста");
                this.Text = Name_Lec;

                if (Action_Type == "change")
                {
                    int id_temi = id_lec(Name_Lec);

                    if (Type_Input == "lecture")
                    {
                        using (MySqlConnection connection = new MySqlConnection(connectionString))
                        {
                            connection.Open();
                            var checkQuery = "SELECT COUNT(*) FROM konspect_lekcii WHERE id_temi = @id_temi";

                            using (MySqlCommand checkCommand = new MySqlCommand(checkQuery, connection))
                            {
                                checkCommand.Parameters.AddWithValue("@id_temi", id_temi);
                                int examplesCount = Convert.ToInt32(checkCommand.ExecuteScalar());

                                if (examplesCount == 0)
                                {
                                    await field_drive.CoreWebView2.ExecuteScriptAsync("document.body.contentEditable = 'true';");
                                }
                                else
                                {
                                    var query = "SELECT konspect FROM konspect_lekcii WHERE id_temi = @id_temi";

                                    using (MySqlCommand command = new MySqlCommand(query, connection))
                                    {
                                        command.Parameters.AddWithValue("@id_temi", id_temi);

                                        using (MySqlDataReader reader = command.ExecuteReader())
                                        {
                                            if (reader.Read() && reader["konspect"] != DBNull.Value)
                                            {
                                                string html_code = reader["konspect"].ToString();
                                                field_drive.NavigateToString(html_code);
                                            }
                                            else
                                            {
                                                string message = "<html><head></head><body>Лекция ещё не внесена</body></html>";
                                                field_drive.NavigateToString(message);
                                            }
                                            await field_drive.CoreWebView2.ExecuteScriptAsync("document.body.contentEditable = 'true';");
                                        }
                                    }
                                }
                            }
                        }

                    }
                    else if (Type_Input == "examples")
                    {
                        using (MySqlConnection connection = new MySqlConnection(connectionString))
                        {
                            connection.Open();
                            var checkQuery = "SELECT COUNT(*) FROM konspetti_primerov WHERE id_temi = @id_temi";

                            using (MySqlCommand checkCommand = new MySqlCommand(checkQuery, connection))
                            {
                                checkCommand.Parameters.AddWithValue("@id_temi", id_temi);
                                int examplesCount = Convert.ToInt32(checkCommand.ExecuteScalar());

                                if (examplesCount == 0)
                                {
                                    await field_drive.CoreWebView2.ExecuteScriptAsync("document.body.contentEditable = 'true';");
                                }
                                else
                                {
                                    var query = "SELECT konspekt_primera FROM konspetti_primerov WHERE id_temi = @id_temi";

                                    using (MySqlCommand command = new MySqlCommand(query, connection))
                                    {
                                        command.Parameters.AddWithValue("@id_temi", id_temi);

                                        using (MySqlDataReader reader = command.ExecuteReader())
                                        {
                                            if (reader.Read() && reader["konspekt_primera"] != DBNull.Value)
                                            {
                                                string html_code = reader["konspekt_primera"].ToString();
                                                field_drive.NavigateToString(html_code);
                                            }
                                            else
                                            {
                                                string message = "<html><head></head><body>Примеры ещё не добавлены</body></html>";
                                                field_drive.NavigateToString(message);
                                            }
                                            await field_drive.CoreWebView2.ExecuteScriptAsync("document.body.contentEditable = 'true';");
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
                else if (Action_Type == "test")
                {
                    save.Visible = false;
                }
            }
            catch (COMException ex) when (ex.HResult == unchecked((int)0x80004004))
            {
            }
            catch (Exception ex)
            {
            }
            await field_drive.CoreWebView2.ExecuteScriptAsync("document.body.contentEditable = 'true';");
        }

        private async Task transferring_hotkeys()
        {
            await field_drive.EnsureCoreWebView2Async(null);

            string script = @"
                document.addEventListener('keydown', function(e) {
                    if (e.ctrlKey && e.shiftKey && e.keyCode === 66) { 
                     e.preventDefault();
                        window.chrome.webview.postMessage('ctrlshiftB');
                    }
                    if (e.ctrlKey && e.shiftKey && e.keyCode === 73) { 
                     e.preventDefault();
                        window.chrome.webview.postMessage('ctrlshiftI');
                    }
                    if (e.ctrlKey && e.shiftKey && e.keyCode === 85) { 
                     e.preventDefault();
                        window.chrome.webview.postMessage('ctrlshiftU');
                    }
                    if (e.ctrlKey && e.shiftKey && e.keyCode === 83) { 
                     e.preventDefault();
                        window.chrome.webview.postMessage('ctrlshiftS');
                    }
                    if (e.ctrlKey && e.keyCode === 76) { 
                     e.preventDefault();
                        window.chrome.webview.postMessage('ctrlL');
                    }
                    if (e.ctrlKey && e.keyCode === 84) { 
                     e.preventDefault();
                        window.chrome.webview.postMessage('ctrlT');
                    }
                     if (e.ctrlKey && e.shiftKey && e.keyCode === 77) { 
                     e.preventDefault();
                        window.chrome.webview.postMessage('ctrlshiftM');
                    }
                     if (e.ctrlKey && e.shiftKey && e.keyCode === 78) { 
                     e.preventDefault();
                        window.chrome.webview.postMessage('ctrlshiftN');
                    }
                     if (e.ctrlKey && e.shiftKey && e.keyCode === 82) { 
                     e.preventDefault();
                        window.chrome.webview.postMessage('ctrlshiftR');
                    }
                     if (e.ctrlKey && e.shiftKey && e.keyCode === 65) { 
                     e.preventDefault();
                        window.chrome.webview.postMessage('ctrlshiftA');
                    }
                     if (e.ctrlKey && e.shiftKey && e.keyCode === 76) { 
                     e.preventDefault();
                        window.chrome.webview.postMessage('ctrlshiftL');
                    }
                     if (e.ctrlKey && e.keyCode === 69) { 
                     e.preventDefault();
                        window.chrome.webview.postMessage('ctrlE');
                    }
                     if (e.ctrlKey && e.keyCode === 82) { 
                     e.preventDefault();
                        window.chrome.webview.postMessage('ctrlR');
                    }
                     if (e.ctrlKey && e.keyCode === 74) { 
                     e.preventDefault();
                        window.chrome.webview.postMessage('ctrlJ');
                    }
                     if (e.ctrlKey && e.shiftKey && e.keyCode === 89) { 
                     e.preventDefault();
                        window.chrome.webview.postMessage('ctrlshiftY');
                     if (e.ctrlKey && e.shiftKey && e.keyCode === 90) { 
                     e.preventDefault();
                        window.chrome.webview.postMessage('ctrlshiftZ');
                    }
                    }
                });
            ";

            Apply_Script(script);
        }

        private void transferring_hotkeys_C_sharp(object sender, CoreWebView2WebMessageReceivedEventArgs e)
        {
            string message = e.TryGetWebMessageAsString();
            if (message == "ctrlshiftB")
            {
                Invoke(new Action(() => {
                    bold_shrift_Click(this, EventArgs.Empty);
                }));
            }
            else if (message == "ctrlshiftI")
            {
                Invoke(new Action(() => { 
                    italicy_shrift_Click(this, EventArgs.Empty);
                }));
            }
            else if (message == "ctrlshiftU")
            {
                Invoke(new Action(() => {
                    underlined_shrift_Click(this, EventArgs.Empty);
                }));
            }
            else if (message == "ctrlshiftS")
            {
                Invoke(new Action(() => {
                    striked_shrift_Click(this, EventArgs.Empty);
                }));
            }
            else if (message == "ctrlL")
            {
                Invoke(new Action(() => {
                    lower_index_Click(this, EventArgs.Empty);
                }));
            }
            else if (message == "ctrlT")
            {
                Invoke(new Action(() => {
                    top_index_Click(this, EventArgs.Empty);
                }));
            }
            else if (message == "ctrlshiftM")
            {
                Invoke(new Action(() => {
                    markers_Click(this, EventArgs.Empty);
                }));
            }
            else if (message == "ctrlshiftN")
            {
                Invoke(new Action(() => {
                    numbered_list_Click(this, EventArgs.Empty);
                }));
            }
            else if (message == "ctrlshiftR")
            {
                Invoke(new Action(() => {
                    reduce_indentation_Click(this, EventArgs.Empty);
                }));
            }
            else if (message == "ctrlshiftA")
            {
                Invoke(new Action(() => {
                    increase_indentation_Click(this, EventArgs.Empty);
                }));
            }
            else if (message == "ctrlshiftL")
            {
                Invoke(new Action(() => {
                    left_alignment_Click(this, EventArgs.Empty);
                }));
            }
            else if (message == "ctrlE")
            {
                Invoke(new Action(() => {
                    center_alignment_Click(this, EventArgs.Empty);
                }));
            }
            else if (message == "ctrlR")
            {
                Invoke(new Action(() => {
                    right_alignment_Click(this, EventArgs.Empty);
                }));
            }
            else if (message == "ctrlJ")
            {
                Invoke(new Action(() => {
                    width_alignment_Click(this, EventArgs.Empty);
                }));
            }
            else if (message == "ctrlshiftY")
            {
                Invoke(new Action(() => {
                    undo_Click(this, EventArgs.Empty);
                }));
            }
            else if (message == "ctrlshiftZ")
            {
                Invoke(new Action(() => {
                    redo_Click(this, EventArgs.Empty);
                }));
            }
        }

        private async Task SetEditableContentInWebView(Microsoft.Web.WebView2.WinForms.WebView2 webView)
        {
            if (webView != null)
            {
                await webView.EnsureCoreWebView2Async();

                string script = "document.body.contentEditable = 'true';";

                Apply_Script(script);
            }
        }
        private void bold_shrift_Click(object sender, EventArgs e)
        {
            string script = @"
            document.execCommand('bold', false, null);
            document.body.focus();";

            Apply_Script(script);

            field_drive.Focus();

        }
        private void italicy_shrift_Click(object sender, EventArgs e)
        {
            string script = @"
            document.execCommand('italic', false, null);
            document.body.focus();";

            Apply_Script(script);

            field_drive.Focus();
        }

        private void underlined_shrift_Click(object sender, EventArgs e)
        {
            string script = @"
            document.execCommand('underline', false, null);
            document.body.focus();";

            Apply_Script(script);

            field_drive.Focus();
        }

        private void striked_shrift_Click(object sender, EventArgs e)
        {
            string script = @"
            document.execCommand('strikeThrough', false, null);
            document.body.focus();";

            Apply_Script(script);

            field_drive.Focus();
        }

        private void lower_index_Click(object sender, EventArgs e)
        {
            string script = @"
            document.execCommand('subscript', false, null);
            document.body.focus();";

            Apply_Script(script);

            field_drive.Focus();
        }

        private void top_index_Click(object sender, EventArgs e)
        {
            string script = @"
            document.execCommand('superscript', false, null);
            document.body.focus();";

            Apply_Script(script);

            field_drive.Focus();
        }

        private void markers_Click(object sender, EventArgs e)
        {
            string script = @"
            document.execCommand('insertUnorderedList', false, null);
            document.body.focus();";

            Apply_Script(script);

            field_drive.Focus();
        }

        private void numbered_list_Click(object sender, EventArgs e)
        {
            string script = @"
            document.execCommand('insertOrderedList', false, null);
            document.body.focus();";

            Apply_Script(script);

            field_drive.Focus();
        }

        private void reduce_indentation_Click(object sender, EventArgs e)
        {
            string script = @"
            document.execCommand('outdent', false, null);
            document.body.focus();";

            Apply_Script(script);

            field_drive.Focus();
        }

        private void increase_indentation_Click(object sender, EventArgs e)
        {
            string script = @"
            document.execCommand('indent', false, null);
            document.body.focus();";

            Apply_Script(script);

            field_drive.Focus();
        }

        private void left_alignment_Click(object sender, EventArgs e)
        {
            string script = @"
            document.execCommand('justifyLeft', false, null);
            document.body.focus();";

            Apply_Script(script);

            field_drive.Focus();
        }

        private void center_alignment_Click(object sender, EventArgs e)
        {
            string script = @"
            document.execCommand('justifyCenter', false, null);
            document.body.focus();";

            Apply_Script(script);

            field_drive.Focus();
        }

        private void right_alignment_Click(object sender, EventArgs e)
        {
            string script = @"
            document.execCommand('justifyRight', false, null);
            document.body.focus();";

            Apply_Script(script);

            field_drive.Focus();
        }

        private void width_alignment_Click(object sender, EventArgs e)
        {
            string script = @"
            document.execCommand('justifyFull', false, null);
            document.body.focus();";

            Apply_Script(script);

            field_drive.Focus();
        }

        private void redo_Click(object sender, EventArgs e)
        {
            string script = "document.execCommand('redo', false, null);";
            Apply_Script(script);

            field_drive.Focus();
        }

        private void undo_Click(object sender, EventArgs e)
        {
            string script = "document.execCommand('undo', false, null);";
            Apply_Script(script);

            field_drive.Focus();
        }

        private void cut_Click(object sender, EventArgs e)
        {
            string script = "document.execCommand('cut', false, null);";
            Apply_Script(script);

            field_drive.Focus();
        }

        private void copy_Click(object sender, EventArgs e)
        {
            string script = @"document.execCommand('copy', false, null);
                var selection = window.getSelection();

            if (!selection.isCollapsed) {
                var anchorNode = selection.anchorNode;
                var focusNode = selection.focusNode;

                var range = document.createRange();
                range.setStartAfter(anchorNode);
                range.setEndAfter(focusNode);

                selection.removeAllRanges();
                selection.addRange(range);
            }

            document.body.focus();";
            Apply_Script(script);

            field_drive.Focus();
        }

        private void add_Click(object sender, EventArgs e)
        {
            string textToPaste = Clipboard.GetText();
            string escapedTextToPaste = System.Web.HttpUtility.JavaScriptStringEncode(textToPaste);
            string script = $"document.execCommand('insertText', false, '{escapedTextToPaste}');";
            Apply_Script(script);

            field_drive.Focus();
        }

        private void highlighting_color_Click(object sender, EventArgs e)
        {
            if (color_selection.ShowDialog() == DialogResult.OK)
            {
                string color = ColorTranslator.ToHtml(color_selection.Color);
                string script = $@"
                document.execCommand('styleWithCSS', false, true);
                document.execCommand('hiliteColor', false, '{color}');
                var selection = window.getSelection();
                if (!selection.isCollapsed) {{
                    var anchorNode = selection.anchorNode;
                    var focusNode = selection.focusNode;

                    var range = document.createRange();
                    range.setStartAfter(anchorNode);
                    range.setEndAfter(focusNode);

                    selection.removeAllRanges();
                    selection.addRange(range);
                }}

                document.body.focus();
                document.execCommand('styleWithCSS', false, false);";

                Apply_Script(script);

                field_drive.Focus();
            }
        }

        private async void print_Click(object sender, EventArgs e)
        {
            if (field_drive.CoreWebView2 != null)
            {
                await field_drive.CoreWebView2.ExecuteScriptAsync("window.print();");
            }
        }

        private void font_color_Click(object sender, EventArgs e)
        {
            if (color_selection.ShowDialog() == DialogResult.OK)
            {
                string color = ColorTranslator.ToHtml(color_selection.Color);
                string script = $@"
                document.execCommand('foreColor', false, '{color}');
                var selection = window.getSelection();
                if (!selection.isCollapsed) {{
                    var anchorNode = selection.anchorNode;
                    var focusNode = selection.focusNode;

                    var range = document.createRange();
                    range.setStartAfter(anchorNode);
                    range.setEndAfter(focusNode);

                    selection.removeAllRanges();
                    selection.addRange(range);
                }}

                document.body.focus();";

                Apply_Script(script);

                field_drive.Focus();
            }
        }

        private void headlines_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selected = style.SelectedItem.ToString();
            string tag;
            switch (selected)
            {
                case "Обычный текст":
                    tag = "p"; 
                    break;
                case "Заголовок первого уровня":
                    tag = "h1";
                    break;
                case "Заголовок второго уровня":
                    tag = "h2";
                    break;
                case "Заголовок третьего уровня":
                    tag = "h3";
                    break;
                case "Заголовок четвёртого уровня":
                    tag = "h4";
                    break;
                case "Заголовок пятого уровня":
                    tag = "h5";
                    break;
                case "Заголовок шестого уровня":
                    tag = "h6";
                    break;
                default:
                    tag = "p";
                    break;
            }

            string script = $@"document.execCommand('formatBlock', false, '<{tag}>');
                document.body.focus();";
            Apply_Script(script);

            field_drive.Focus();

        }

        private void fonts_DrawItem(object sender, DrawItemEventArgs e)
        {
            e.DrawBackground(); 

            if (e.Index < 0) return; 

            var text = fonts.Items[e.Index].ToString();

            using (var standardFont = new Font("Times New Roman", 12))
            {
                e.Graphics.DrawString(text, standardFont, SystemBrushes.ControlText, e.Bounds);

                SizeF stringSize = e.Graphics.MeasureString(text, standardFont);

                string sampleText = "AaBbCc";

                using (var fontSample = new Font(text, 11))
                {
                    float sampleTextStart = e.Bounds.Left + stringSize.Width + 5; 

                    e.Graphics.DrawString(sampleText, fontSample, SystemBrushes.ControlText, new PointF(sampleTextStart, e.Bounds.Top));
                }
            }

            e.DrawFocusRectangle();  
        }

        private void fonts_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (fonts.SelectedItem != null)
            {
                string font_name = fonts.SelectedItem.ToString();
                string script = $@"
            (function() {{
                var selection = window.getSelection();
                if (!selection.isCollapsed) {{ 
                    document.execCommand('fontName', false, '{font_name}');
                }} else {{ 
                    var span = document.createElement('span');
                    span.style.fontFamily = '{font_name}';
                    span.appendChild(document.createTextNode('\u200B')); 
                    selection.getRangeAt(0).insertNode(span);

                    var range = document.createRange();
                    range.setStartAfter(span.firstChild);
                    range.collapse(true);
                    selection.removeAllRanges();
                    selection.addRange(range);
                }}
                document.body.focus(); 
            }})();";

                Apply_Script(script);

                field_drive.Focus();
            }
        }

        private void font_size_SelectedIndexChanged(object sender, EventArgs e)
        {
            choosing_font_size();
        }

        private void choosing_font_size()
        {
            if (field_drive.CoreWebView2 == null)
                return;

            if (int.TryParse(font_size.Text, out int fontSize))
            {
                string script = $@"
                (function() {{
                    var selection = window.getSelection();
                    if (!selection.isCollapsed) {{ 
                        var range = selection.getRangeAt(0);
                        var selectedContents = range.extractContents();

                        var fragment = document.createDocumentFragment();

                        Array.from(selectedContents.childNodes).forEach(node => {{
                            var span = document.createElement('span');
                            span.style.fontSize = '{fontSize}pt'; 
                            if (node.nodeType === 3) {{ 
                                span.textContent = node.textContent;
                                fragment.appendChild(span);
                            }} else if (node.nodeType === 1) {{ 
                                node.style.fontSize = '{fontSize}pt'; 
                                fragment.appendChild(node.cloneNode(true));
                            }}
                        }});
                        range.insertNode(fragment);
                    }} else {{ 
                        var span = document.createElement('span');
                        span.style.fontSize = '{fontSize}pt';
                        span.appendChild(document.createTextNode(String.fromCharCode(8203))); 
                        selection.getRangeAt(0).insertNode(span);

                        var range = document.createRange();
                        range.setStartAfter(span.firstChild);
                        range.collapse(true);
                        selection.removeAllRanges();
                        selection.addRange(range);
                    }}
                    document.body.focus(); 
                }})();";
                Apply_Script(script);

                field_drive.Focus();
            }
            else
            {
                MessageBox.Show("Введите корректное значение размера шрифта.");
            }
        }
        private void font_size_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                choosing_font_size();
            }
        }
        private bool check_allocation = false;
        private async void find_Click(object sender, EventArgs e)
        {

            string search_text = text_find.Text;
            string script;
            string Json_search_text = JsonConvert.SerializeObject(search_text);

            if (!string.IsNullOrEmpty(search_text))
            {
                if (check_allocation)
                {
                    script = @"
                        (function() {
                            var highlighted = document.querySelectorAll('.highlight-search-text'); 
                            highlighted.forEach(function(span) {
                                var parent = span.parentNode;
                                parent.replaceChild(document.createTextNode(span.textContent), span);
                                parent.normalize();
                            });
                        })();
                    ";
                    check_allocation = false;
                }
                else
                {
                    script = @"
                    (function() {
                        var search_text = " + Json_search_text + @";
                        var regex = new RegExp(search_text.replace(/[-\/\\^$*+?.()|[\]{{}}]/g, '\\$&'), 'gi');
                        var elements = document.querySelectorAll(':not(script):not(style):not([class^=""highlight-search-text""])'); 
                        var found = false;
                            for (var i = 0; i < elements.length; i++) {
                            var element = elements[i];
                            if (element.childNodes.length === 1 && element.childNodes[0].nodeType === 3) { 
                                var textContent = element.textContent;
                                if (textContent.match(regex)) {
                                    var newHTML = textContent.replace(regex, '<span class=""highlight-search-text"" style=""background-color: yellow;"">$&</span>');
                                    element.innerHTML = newHTML;
                                    found = true;
                                }
                            }
                        }
                    return found;
                    })();
                ";
                }
                string result = await field_drive.CoreWebView2.ExecuteScriptAsync(script);
                result = result.Trim('"');
                bool found_с = result.Equals("true", StringComparison.OrdinalIgnoreCase);
                check_allocation = found_с;
            }
            else
            {
                MessageBox.Show("Введите текст для поиска.");
            }
        }

        private void replace_Click(object sender, EventArgs e)
        {
            string search_text = text_find.Text;
            string replacement_text = text_replace.Text;
            if (text_find.Text != null)
            {
                string script = $@"
                (function() {{
                    var highlighted = document.querySelectorAll('.highlight-search-text');
                    highlighted.forEach(function(span) {{
                        var parent = span.parentNode;
                        parent.replaceChild(document.createTextNode(span.textContent), span);
                    }});

                    var search_text = {JsonConvert.SerializeObject(search_text)};
                    var replacement_text = {JsonConvert.SerializeObject(replacement_text)};
                    var regex = new RegExp(search_text, 'g');
                    document.body.innerHTML = document.body.innerHTML.replace(regex, replacement_text);
                }})();";
                check_allocation = false;

                Apply_Script(script);

            }
            else
            {
                MessageBox.Show("Введите текст, который нужно заменить.");
            }
        }

        private void open_formula_editor_Click(object sender, EventArgs e)
        {
            formula_editor Myformula_editor = new formula_editor();
            Myformula_editor.Show();
        }

        private void insert_image_Click(object sender, EventArgs e)
        {
            string path_to_Formulas = Path.Combine(Application.StartupPath, "formulas");
            openFileDialog1.InitialDirectory = path_to_Formulas;
            openFileDialog1.Filter = "Image Files(*.png;*.jpg;*.jpeg;*.gif;*.bmp)|*.png;*.jpg;*.jpeg;*.gif;*.bmp|All files (*.*)|*.*";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string image_Base64 = Convert.ToBase64String(File.ReadAllBytes(openFileDialog1.FileName));
                string img_Tag = $"<img src=\"data:image/png;base64,{image_Base64}\" />";
                string script = $@"document.execCommand('insertHTML', false, `{img_Tag}`);
                document.body.focus();";

                Apply_Script(script);

                field_drive.Focus();
            }
        }

        private async void save_Click(object sender, EventArgs e)
        {
            await field_drive.CoreWebView2.ExecuteScriptAsync("document.body.contentEditable = 'false';");
            string html_content = await field_drive.CoreWebView2.ExecuteScriptAsync("document.documentElement.outerHTML;");
            html_content = Newtonsoft.Json.JsonConvert.DeserializeObject<string>(html_content);
            if (Action_Type == "change")
            {
                if (Type_Input == "lecture")
                {
                    update_content(html_content, "konspect_lekcii", "konspect");
                }
                else if (Type_Input == "examples")
                {
                    update_content(html_content, "konspetti_primerov", "konspekt_primera");
                }
                await field_drive.CoreWebView2.ExecuteScriptAsync("document.body.contentEditable = 'true';");
            }
            else
            {
                if (Type_Input == "lecture")
                {
                    save_content(html_content, "konspect_lekcii", "konspect");
                }
                else if (Type_Input == "examples")
                {
                    save_content(html_content, "konspetti_primerov", "konspekt_primera");
                }
                Close();
            }
        }

        private void update_content(string content, string table_Name, string column)
        {
            string query = $"UPDATE {table_Name} SET {column} = @content WHERE id_temi = @id_temi";
            int id_temi = id_lec(Name_Lec);

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id_temi", id_temi);
                    command.Parameters.AddWithValue("@content", content);

                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show($"Содержимое успешно обновлено.", "Обновление", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        save_content(content, table_Name, column);
                    }
                }
            }
        }

        private void save_content(string content, string table_Name, string column)
        {
            int id_temi = id_lec(Name_Lec);
            string query = $"INSERT INTO {table_Name} (id_temi, {column}) VALUES (@id_temi, @content)";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id_temi", id_temi);
                    command.Parameters.AddWithValue("@content", content);
                    command.ExecuteNonQuery();
                }
            }
            MessageBox.Show($"Содержимое успешно сохранено.", "Сохранение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private int id_lec(string name_lec)
        {
            int id_lec = 0;

            string vopr = "SELECT id_temi FROM temi WHERE name_temi = @name_lec";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                using (MySqlCommand command = new MySqlCommand(vopr, connection))
                {
                    command.Parameters.AddWithValue("@name_lec", name_lec);

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            id_lec = reader.GetInt32("id_temi");
                        }
                    }
                }
            }
            return id_lec;
        }

        private void adding_Click(object sender, EventArgs e)
        {
            Editor.ActiveForm.Hide();
            add_lecture Myadd_lecture = new add_lecture();
            Myadd_lecture.ShowDialog();
            Close();
        }

        private async Task initialization_additional_scripts()
        {
            field_drive.CoreWebView2.WebMessageReceived -= transferring_hotkeys_C_sharp;

            field_drive.CoreWebView2.WebMessageReceived += transferring_hotkeys_C_sharp;

            await transferring_hotkeys();

        }

        private async void field_drive_NavigationCompleted_1(object sender, CoreWebView2NavigationCompletedEventArgs e)
        {
            if (e.IsSuccess)
            {
                await initialization_additional_scripts();
            }
        }

        private void Apply_Script(string script)
        {
            field_drive.CoreWebView2.ExecuteScriptAsync(script);
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About_program MyAbout_program = new About_program();
            MyAbout_program.ShowDialog();
        }

        private void закрытьОкноToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Убедитесь, что вы сохранили данные. Если вы ничего не вносили, то нажмите 'Да'.", "Подтверждение закрытия окна", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                Close();
            }
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Убедитесь, что вы сохранили данные. Если вы ничего не вносили, то нажмите 'Да'.", "Подтверждение закрытия окна", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                Editor.ActiveForm.Hide();
                Vxod MyVxod = new Vxod();
                MyVxod.ShowDialog();
                Close();
            }
        }
    }
}
