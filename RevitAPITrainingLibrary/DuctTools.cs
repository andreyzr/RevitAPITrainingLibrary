using Autodesk.Revit.DB;
using Autodesk.Revit.DB.Mechanical;
using Autodesk.Revit.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevitAPITrainingLibrary
{
    public class DuctTools
    {
        public static List<DuctType> GetDuctTypes(ExternalCommandData commandData)
        {
            UIApplication uiapp = commandData.Application;
            UIDocument uidoc = uiapp.ActiveUIDocument;
            Document doc = uidoc.Document;

            List<DuctType> ductTypes = new FilteredElementCollector(doc)
                                                        .OfClass(typeof(DuctType))
                                                        .Cast<DuctType>()
                                                        .ToList();

            return ductTypes;
        }

        public static List<MechanicalSystemType> GetSystemType(ExternalCommandData commandData)
        {
            UIApplication uiapp = commandData.Application;
            UIDocument uidoc = uiapp.ActiveUIDocument;
            Document doc = uidoc.Document;

            List<MechanicalSystemType> sysTypes = new FilteredElementCollector(doc)
                                                        .OfClass(typeof(MechanicalSystemType))
                                                        .Cast<MechanicalSystemType>()
                                                        .ToList();

            return sysTypes;
        }


    }
}
