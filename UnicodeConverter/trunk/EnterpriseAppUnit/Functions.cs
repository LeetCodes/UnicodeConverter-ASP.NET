using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;
using System.Xml;
using System.Reflection;

namespace Hajloo.FOSS.UnicodeConverter.EnterpriseAppUnit
{
    public class Functions
    {
        #region Public Methods
        /// <summary>
        /// Convert a Hex Code to a valid character, if hex code do not return a valid character then a unknown character return;
        /// </summary>
        /// <param name="hexCode">a valid Unicode Hex Code</param>
        /// <returns>a valid unicode character</returns>
        public static char ConvertHexToUnicode(string hexCode)
        {
            if (hexCode != string.Empty)
                return ((char)int.Parse(hexCode, NumberStyles.AllowHexSpecifier));
            
            char empty = new char();
            return empty;
        }//end

        public static char ConvertDecimalToChar(Int64 decimalValue)
        {
            return ((char)int.Parse(decimalValue.ToString(), NumberStyles.Integer));
            char unknown = new char();
            return unknown;
        }

        /// <summary>
        /// Get decimal value of character
        /// </summary>
        /// <param name="character">a valid character</param>
        /// <returns>decimal value of character</returns>
        public static long GetDecimal(char character)
        {
            return Convert.ToInt64(character);
        }//end

        /// <summary>
        /// Get Hexadecimal value of a character
        /// </summary>
        /// <param name="character">a valid character</param>
        /// <returns>Hexadecimal value of a character that represent unicode value</returns>
        public static string GetHexCode(char character)
        {
            return string.Format("{0:X4}", GetDecimal(character));
        }//end
        #endregion

        #region Reading Unicode XML
        /// <summary>
        /// Get Valid Unicode name of a character
        /// </summary>
        /// <param name="character">a character to get name</param>
        /// <returns>valid Unicode name</returns>
        public static string GetName(char character)
        {
            XmlDocument xml = new XmlDocument();
            XmlReaderSettings settings = new XmlReaderSettings();
            settings.ConformanceLevel = ConformanceLevel.Auto;
            settings.ValidationType = ValidationType.Schema;
            settings.IgnoreWhitespace = true;
            settings.IgnoreComments = true;
            settings.ConformanceLevel = ConformanceLevel.Auto;
            System.Reflection.Assembly asm = Assembly.GetExecutingAssembly();
            System.IO.Stream xmlStream = asm.GetManifestResourceStream("Hajloo.FOSS.UnicodeConverter.EnterpriseAppUnit.ucd.all.flat.xml");
            XmlReader reader = XmlReader.Create(xmlStream, settings);

            reader.Read();
            reader.ReadStartElement();
            while (reader.Read())
            {
                if (reader.IsEmptyElement)
                {
                    if (GetHexCode(character) == reader.GetAttribute("cp"))
                        return reader.GetAttribute("na");
                }
            }
            return string.Empty;
        }//end

        /// <summary>
        /// Get Valid Unicode Type of a character
        /// </summary>
        /// <param name="character">a character to get Unicode Type</param>
        /// <returns>Valid unicode type</returns>
        public static string GetType(char character)
        {
            XmlDocument xml = new XmlDocument();
            XmlReaderSettings settings = new XmlReaderSettings();
            settings.ConformanceLevel = ConformanceLevel.Auto;
            settings.ValidationType = ValidationType.Schema;
            settings.IgnoreWhitespace = true;
            settings.IgnoreComments = true;
            settings.ConformanceLevel = ConformanceLevel.Auto;
            System.Reflection.Assembly asm = Assembly.GetExecutingAssembly();
            System.IO.Stream xmlStream = asm.GetManifestResourceStream("Hajloo.FOSS.UnicodeConverter.EnterpriseAppUnit.ucd.all.flat.xml");
            XmlReader reader = XmlReader.Create(xmlStream, settings);

            reader.Read();
            reader.ReadStartElement();
            while (reader.Read())
            {
                if (reader.IsEmptyElement)
                {
                    if (GetHexCode(character) == reader.GetAttribute("cp"))
                        return reader.GetAttribute("jt");
                }
            }
            return string.Empty;
        }//end

        /// <summary>
        /// Get Valid Unicode Category Name of a character
        /// </summary>
        /// <param name="character">a character to get category</param>
        /// <returns>Valid Unicode Category Name</returns>
        public static string GetCategory(char character)
        {
            XmlDocument xml = new XmlDocument();
            XmlReaderSettings settings = new XmlReaderSettings();
            settings.ConformanceLevel = ConformanceLevel.Auto;
            settings.ValidationType = ValidationType.Schema;
            settings.IgnoreWhitespace = true;
            settings.IgnoreComments = true;
            settings.ConformanceLevel = ConformanceLevel.Auto;
            System.Reflection.Assembly asm = Assembly.GetExecutingAssembly();
            System.IO.Stream xmlStream = asm.GetManifestResourceStream("Hajloo.FOSS.UnicodeConverter.EnterpriseAppUnit.ucd.all.flat.xml");
            XmlReader reader = XmlReader.Create(xmlStream, settings);

            reader.Read();
            reader.ReadStartElement();
            string categoryCode = string.Empty;
            while (reader.Read())
            {
                if (reader.IsEmptyElement)
                {
                    if (GetHexCode(character) == reader.GetAttribute("cp"))
                        return reader.GetAttribute("jg");
                }
            }
            return string.Empty;
        }//end

        /// <summary>
        /// Get Valid Unicode Page Category of a character
        /// </summary>
        /// <param name="character">Character</param>
        /// <returns>Character Page Category like Latin, Arab, ...</returns>
        public static string GetUnicodePage(char character)
        {
            XmlDocument xml = new XmlDocument();
            XmlReaderSettings settings = new XmlReaderSettings();
            settings.ConformanceLevel = ConformanceLevel.Auto;
            settings.ValidationType = ValidationType.Schema;
            settings.IgnoreWhitespace = true;
            settings.IgnoreComments = true;
            settings.ConformanceLevel = ConformanceLevel.Auto;
            System.Reflection.Assembly asm = Assembly.GetExecutingAssembly();
            System.IO.Stream xmlStream = asm.GetManifestResourceStream("Hajloo.FOSS.UnicodeConverter.EnterpriseAppUnit.ucd.all.flat.xml");
            XmlReader reader = XmlReader.Create(xmlStream, settings);

            reader.Read();
            reader.ReadStartElement();
            while (reader.Read())
            {
                if (reader.IsEmptyElement)
                {
                    if (GetHexCode(character) == reader.GetAttribute("cp"))
                        return reader.GetAttribute("sc");
                }
            }
            return string.Empty;
        }//end

        /// <summary>
        /// indicate that a character is Bidirectional or not
        /// </summary>
        /// <param name="character">Character</param>
        /// <returns>N / Y</returns>
        public static string GetBiDI(char character)
        {
            XmlDocument xml = new XmlDocument();
            XmlReaderSettings settings = new XmlReaderSettings();
            settings.ConformanceLevel = ConformanceLevel.Auto;
            settings.ValidationType = ValidationType.Schema;
            settings.IgnoreWhitespace = true;
            settings.IgnoreComments = true;
            settings.ConformanceLevel = ConformanceLevel.Auto;
            System.Reflection.Assembly asm = Assembly.GetExecutingAssembly();
            System.IO.Stream xmlStream = asm.GetManifestResourceStream("Hajloo.FOSS.UnicodeConverter.EnterpriseAppUnit.ucd.all.flat.xml");
            XmlReader reader = XmlReader.Create(xmlStream, settings);

            reader.Read();
            reader.ReadStartElement();
            while (reader.Read())
            {
                if (reader.IsEmptyElement)
                {
                    if (GetHexCode(character) == reader.GetAttribute("cp"))
                        return reader.GetAttribute("Bidi_C");
                }
            }
            return string.Empty;
        }//end
#endregion        

        #region Reading Standard XML
        public static List<string> GetAllAvailableCountries()
        {
            List<string> list = new List<string>();
            XmlDocument xml = new XmlDocument();
            XmlReaderSettings settings = new XmlReaderSettings();
            settings.ConformanceLevel = ConformanceLevel.Auto;
            settings.ValidationType = ValidationType.Schema;
            settings.IgnoreWhitespace = true;
            settings.IgnoreComments = true;
            settings.ConformanceLevel = ConformanceLevel.Auto;
            System.Reflection.Assembly asm = Assembly.GetExecutingAssembly();
            System.IO.Stream xmlStream = asm.GetManifestResourceStream("Hajloo.FOSS.UnicodeConverter.EnterpriseAppUnit.Standards.xml");
            XmlReader reader = XmlReader.Create(xmlStream, settings);

            while (reader.Read())
            {
                if (reader.IsEmptyElement)
                    list.Add(reader.GetAttribute("Country"));
            }
            return list;
        }

        /// <summary>
        /// Get Standard Keyboard Layout Name of a country
        /// </summary>
        /// <param name="country">Country</param>
        /// <returns>Standard Keyboard Layout Name</returns>
        public static string GetKeyboardLayout(string country)
        {
            XmlDocument xml = new XmlDocument();
            XmlReaderSettings settings = new XmlReaderSettings();
            settings.ConformanceLevel = ConformanceLevel.Auto;
            settings.ValidationType = ValidationType.Schema;
            settings.IgnoreWhitespace = true;
            settings.IgnoreComments = true;
            settings.ConformanceLevel = ConformanceLevel.Auto;
            System.Reflection.Assembly asm = Assembly.GetExecutingAssembly();
            System.IO.Stream xmlStream = asm.GetManifestResourceStream("Hajloo.FOSS.UnicodeConverter.EnterpriseAppUnit.Standards.xml");
            XmlReader reader = XmlReader.Create(xmlStream, settings);

            while (reader.Read())
            {
                if (reader.IsEmptyElement)
                {
                    if (country == reader.GetAttribute("Country"))
                        return reader.GetAttribute("KeyboardLayout");
                }
            }
            return string.Empty;
        }//end

        /// <summary>
        /// Get Standard Date of standard keyboard layout 
        /// </summary>
        /// <param name="country">Country</param>
        /// <returns>keyboard layout Standard Date</returns>
        public static string GetStandardDate(string country)
        {
            XmlDocument xml = new XmlDocument();
            XmlReaderSettings settings = new XmlReaderSettings();
            settings.ConformanceLevel = ConformanceLevel.Auto;
            settings.ValidationType = ValidationType.Schema;
            settings.IgnoreWhitespace = true;
            settings.IgnoreComments = true;
            settings.ConformanceLevel = ConformanceLevel.Auto;
            System.Reflection.Assembly asm = Assembly.GetExecutingAssembly();
            System.IO.Stream xmlStream = asm.GetManifestResourceStream("Hajloo.FOSS.UnicodeConverter.EnterpriseAppUnit.Standards.xml");
            XmlReader reader = XmlReader.Create(xmlStream, settings);

            while (reader.Read())
            {
                if (reader.IsEmptyElement)
                {
                    if (country == reader.GetAttribute("Country"))
                        return reader.GetAttribute("StandardDate");
                }
            }
            return string.Empty;
        }//end

        /// <summary>
        /// Get Publisher of standard keyboard layout of a country
        /// </summary>
        /// <param name="country">Country</param>
        /// <returns>Publisher of standard keyboard layout</returns>
        public static string GetProducer(string country)
        {
            XmlDocument xml = new XmlDocument();
            XmlReaderSettings settings = new XmlReaderSettings();
            settings.ConformanceLevel = ConformanceLevel.Auto;
            settings.ValidationType = ValidationType.Schema;
            settings.IgnoreWhitespace = true;
            settings.IgnoreComments = true;
            settings.ConformanceLevel = ConformanceLevel.Auto;
            System.Reflection.Assembly asm = Assembly.GetExecutingAssembly();
            System.IO.Stream xmlStream = asm.GetManifestResourceStream("Hajloo.FOSS.UnicodeConverter.EnterpriseAppUnit.Standards.xml");
            XmlReader reader = XmlReader.Create(xmlStream, settings);

            while (reader.Read())
            {
                if (reader.IsEmptyElement)
                {
                    if (country == reader.GetAttribute("Country"))
                        return reader.GetAttribute("Producer");
                }
            }
            return string.Empty;
        }//end

        /// <summary>
        /// Get Project License of standard keyboard layout of a country
        /// </summary>
        /// <param name="country">Country</param>
        /// <returns>Project License of standard keyboard layout</returns>
        public static string GetLicense(string country)
        {
            XmlDocument xml = new XmlDocument();
            XmlReaderSettings settings = new XmlReaderSettings();
            settings.ConformanceLevel = ConformanceLevel.Auto;
            settings.ValidationType = ValidationType.Schema;
            settings.IgnoreWhitespace = true;
            settings.IgnoreComments = true;
            settings.ConformanceLevel = ConformanceLevel.Auto;
            System.Reflection.Assembly asm = Assembly.GetExecutingAssembly();
            System.IO.Stream xmlStream = asm.GetManifestResourceStream("Hajloo.FOSS.UnicodeConverter.EnterpriseAppUnit.Standards.xml");
            XmlReader reader = XmlReader.Create(xmlStream, settings);

            while (reader.Read())
            {
                if (reader.IsEmptyElement)
                {
                    if (country == reader.GetAttribute("Country"))
                        return reader.GetAttribute("License");
                }
            }
            return string.Empty;
        }//end

        /// <summary>
        /// Get Referer of standard keyboard layout of a country
        /// </summary>
        /// <param name="country">Country</param>
        /// <returns>Referer Name</returns>
        public static string GetReferer(string country)
        {
            XmlDocument xml = new XmlDocument();
            XmlReaderSettings settings = new XmlReaderSettings();
            settings.ConformanceLevel = ConformanceLevel.Auto;
            settings.ValidationType = ValidationType.Schema;
            settings.IgnoreWhitespace = true;
            settings.IgnoreComments = true;
            settings.ConformanceLevel = ConformanceLevel.Auto;
            System.Reflection.Assembly asm = Assembly.GetExecutingAssembly();
            System.IO.Stream xmlStream = asm.GetManifestResourceStream("Hajloo.FOSS.UnicodeConverter.EnterpriseAppUnit.Standards.xml");
            XmlReader reader = XmlReader.Create(xmlStream, settings);

            while (reader.Read())
            {
                if (reader.IsEmptyElement)
                {
                    if (country == reader.GetAttribute("Country"))
                        return reader.GetAttribute("Referer");
                }
            }
            return string.Empty;
        }//end

        /// <summary>
        /// Get Referer Mail of standard keyboard layout of a country
        /// </summary>
        /// <param name="country">Country</param>
        /// <returns>Referer Mail</returns>
        public static string GetRefererMail(string country)
        {
            XmlDocument xml = new XmlDocument();
            XmlReaderSettings settings = new XmlReaderSettings();
            settings.ConformanceLevel = ConformanceLevel.Auto;
            settings.ValidationType = ValidationType.Schema;
            settings.IgnoreWhitespace = true;
            settings.IgnoreComments = true;
            settings.ConformanceLevel = ConformanceLevel.Auto;
            System.Reflection.Assembly asm = Assembly.GetExecutingAssembly();
            System.IO.Stream xmlStream = asm.GetManifestResourceStream("Hajloo.FOSS.UnicodeConverter.EnterpriseAppUnit.Standards.xml");
            XmlReader reader = XmlReader.Create(xmlStream, settings);

            while (reader.Read())
            {
                if (reader.IsEmptyElement)
                {
                    if (country == reader.GetAttribute("Country"))
                        return reader.GetAttribute("RefererMail");
                }
            }
            return string.Empty;
        }//end

        /// <summary>
        /// Get Project URL of a Standard keyboard layout for a country
        /// </summary>
        /// <param name="country">Country</param>
        /// <returns>valid project URL for downloading standard keyboard layout</returns>
        public static string GetProjectURL(string country)
        {
            XmlDocument xml = new XmlDocument();
            XmlReaderSettings settings = new XmlReaderSettings();
            settings.ConformanceLevel = ConformanceLevel.Auto;
            settings.ValidationType = ValidationType.Schema;
            settings.IgnoreWhitespace = true;
            settings.IgnoreComments = true;
            settings.ConformanceLevel = ConformanceLevel.Auto;
            System.Reflection.Assembly asm = Assembly.GetExecutingAssembly();
            System.IO.Stream xmlStream = asm.GetManifestResourceStream("Hajloo.FOSS.UnicodeConverter.EnterpriseAppUnit.Standards.xml");
            XmlReader reader = XmlReader.Create(xmlStream, settings);

            while (reader.Read())
            {
                if (reader.IsEmptyElement)
                {
                    if (country == reader.GetAttribute("Country"))
                        return reader.GetAttribute("ProjectURL");
                }
            }
            return string.Empty;
        }//end
        #endregion
    }
}
