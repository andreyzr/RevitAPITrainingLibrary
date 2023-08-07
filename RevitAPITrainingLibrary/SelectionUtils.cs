using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using Autodesk.Revit.UI.Selection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RevitAPITrainingLibrary;
using Prism.Commands;

namespace RevitAPITrainingLibrary
{
    public class SelectionUtils
    {
        public static Element PickObject(ExternalCommandData commandData,string massage= "Выберете элемент")
        {
            UIApplication uiapp = commandData.Application;
            UIDocument uidoc = uiapp.ActiveUIDocument;
            Document doc = uidoc.Document;

            var selectedObject = uidoc.Selection.PickObject(ObjectType.Element, massage);
            var oElement = doc.GetElement(selectedObject);
            return oElement;
        }

        public static List<Element> PickedObjects(ExternalCommandData commandData, string massage = "Выберете элемент")
        {
            UIApplication uiapp = commandData.Application;
            UIDocument uidoc = uiapp.ActiveUIDocument;
            Document doc = uidoc.Document;

            Reference selectedObjects = uidoc.Selection.PickObject(ObjectType.Element, massage);
            List<Element> elementList = selectedObjects.Select(selectedObjects=>doc.GetElement(selectedObjects)).ToList();
            return ;
        }

    }
}
