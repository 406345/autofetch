using autofetch.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace autofetch
{
    class Projects
    {

        private static Projects _instance = new Projects();
        public static Projects Instance
        {
            get
            {
                return _instance;
            }
        }

        public Projects()
        {
            projectInfos = new List<ProjectInfo>();
        }

        private List<ProjectInfo> projectInfos;// = new List<ProjectInfo>();
        private object projectInfosLock = new object();

        public void Add(ProjectInfo info)
        {
            lock (projectInfosLock)
            {
                this.projectInfos.Add(info);
            }
        }

        public void Remove(ProjectInfo info)
        {
            lock (projectInfosLock)
            {
                this.projectInfos.Remove(info);
            }
        }

        public List<ProjectInfo> GetProjects()
        {
            List<ProjectInfo> copy = new List<ProjectInfo>();
            lock (projectInfosLock)
            {
                copy = projectInfos.ToList();
            }

            return copy;
        }

        public void Load()
        {
            string jsons = "";

            if (System.IO.File.Exists("./project.data"))
            {
                jsons = System.IO.File.ReadAllText("./project.data");
            }

            projectInfos = Newtonsoft.Json.JsonConvert.DeserializeObject<List<ProjectInfo>>(jsons) ?? new List<ProjectInfo>
                ();
        }
        public void Persist()
        {
            System.IO.File.WriteAllText(
                "./project.data",
                Newtonsoft.Json.JsonConvert.SerializeObject(this.projectInfos));
        }
    }
}
