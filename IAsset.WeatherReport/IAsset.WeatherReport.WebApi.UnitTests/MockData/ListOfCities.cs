using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IAsset.WeatherReport.WebApi.UnitTests.MockData
{
    public class ListOfCities
    {
        public static string citiesList = @"<NewDataSet>
  <Table>
    <Country>Mali</Country>
    <City>Bougouni</City>
  </Table>
  <Table>
    <Country>Mali</Country>
    <City>Bamako / Senou</City>
  </Table>
  <Table>
    <Country>Mali</Country>
    <City>Gao</City>
  </Table>
  <Table>
    <Country>Mali</Country>
    <City>Hombori</City>
  </Table>
  <Table>
    <Country>Mali</Country>
    <City>Kenieba</City>
  </Table>
  <Table>
    <Country>Mali</Country>
    <City>Kidal</City>
  </Table>
  <Table>
    <Country>Mali</Country>
    <City>Koutiala</City>
  </Table>
  <Table>
    <Country>Mali</Country>
    <City>Kita</City>
  </Table>
  <Table>
    <Country>Mali</Country>
    <City>Kayes</City>
  </Table>
  <Table>
    <Country>Mali</Country>
    <City>Mopti</City>
  </Table>
  <Table>
    <Country>Mali</Country>
    <City>Menaka</City>
  </Table>
  <Table>
    <Country>Mali</Country>
    <City>Nara</City>
  </Table>
  <Table>
    <Country>Mali</Country>
    <City>Nioro Du Sahel</City>
  </Table>
  <Table>
    <Country>Mali</Country>
    <City>Segou</City>
  </Table>
  <Table>
    <Country>Mali</Country>
    <City>Sikasso</City>
  </Table>
  <Table>
    <Country>Mali</Country>
    <City>San</City>
  </Table>
  <Table>
    <Country>Mali</Country>
    <City>Tombouctou</City>
  </Table>
  <Table>
    <Country>Mali</Country>
    <City>Tessalit</City>
  </Table>
  <Table>
    <Country>Somalia</Country>
    <City>Hargeisa</City>
  </Table>
  <Table>
    <Country>Somalia</Country>
    <City>Berbera</City>
  </Table>
  <Table>
    <Country>Somalia</Country>
    <City>Mogadiscio</City>
  </Table>
  <Table>
    <Country>Somalia</Country>
    <City>Belet Uen</City>
  </Table>
  <Table>
    <Country>Somalia</Country>
    <City>Burao</City>
  </Table>
</NewDataSet>";

        public static string weatherDetails = @"<?xml version=""1.0"" encoding=""utf-16""?>
<CurrentWeather>
  <Location>Gao, Mali (GAGO) 16-16N 000-03W 260M</Location>
  <Time>Nov 20, 2015 - 03:00 PM EST / 2015.11.20 2000 UTC</Time>
  <Status>Success</Status>
</CurrentWeather>";
    }
}
