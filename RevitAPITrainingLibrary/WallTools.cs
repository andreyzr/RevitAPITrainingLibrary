﻿using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace RevitAPITrainingLibrary
{
    public class WallTools
    {
        public static List<WallType> GetWallTypes(ExternalCommandData commandData)
        {
            UIApplication uiapp = commandData.Application;
            UIDocument uidoc = uiapp.ActiveUIDocument;
            Document doc = uidoc.Document;

            List<WallType> wallTypes = new FilteredElementCollector(doc)
                                                        .OfClass(typeof(WallType))
                                                        .Cast<WallType>()
                                                        .ToList();

            return wallTypes;
        }

    }
}
