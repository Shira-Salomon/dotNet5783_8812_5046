﻿using DalApi;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Dal
{
    // Implementation of the IDal interface
    sealed public class DalXml : IDal
    {
        public IDependency Dependency => new DependencyImplementation();
        public IEngineer Engineer => new EngineerImplementation();
        public ITask Task => new TaskImplementation();

        /// <summary>
        /// Action to delete entity data from the files. 
        /// </summary>
        public void Reset()
        {
            //Opening the entity files, deleting and closing the file
            XElement rootDependency = XMLTools.LoadListFromXMLElement("dependencies");
            rootDependency.Elements().Remove();
            XMLTools.SaveListToXMLElement(rootDependency, "dependencies");
            XElement rootTask = XMLTools.LoadListFromXMLElement("tasks");
            rootTask.Elements().Remove();
            XMLTools.SaveListToXMLElement(rootTask, "tasks");
            XElement rootEngineer = XMLTools.LoadListFromXMLElement("engineers");
            rootEngineer.Elements().Remove();
            XMLTools.SaveListToXMLElement(rootEngineer, "engineers");
        }

        /// <summary>
        /// /// Action to return the end date of the project. 
        /// </summary>
        /// <returns></returns>
        public DateTime? ReturnEndProject()
        {
            return Config.endProject;
        }

        /// <summary>
        /// /// Action to return the start date of the project
        /// </summary>
        /// <returns></returns>
        public DateTime? ReturnStartProject()
        {
            return Config.startProject;
        }

        /// <summary>
        /// Action to update the end date of the project.
        /// </summary>
        /// <param name="value"></param>
        public void UpdateEndProject(DateTime? value)
        {
            Config.endProject = value;
        }

        /// <summary>
        /// Action to update the project start date
        /// </summary>
        /// <param name="value"></param>
        public void UpdateStartProject(DateTime? value)
        {
            Config.startProject = value;
        }
    }
}
