using autofetch.Model;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace autofetch
{
    class GitAPI
    {
        public ProjectInfo project { get; private set; }
        public GitAPI(ProjectInfo info)
        {
            this.project = info;
        }

        public string Output { get; private set; }
        public string Error { get; private set; }
        public bool Fetch()
        {
            return 0 == Exec("git", "fetch", "origin", this.project.Branch);
        }

        public bool Merge()
        {
            return 0 == Exec("git", "merge", "origin/" + project.Branch);
        }

        private int Exec(string file, params string[] args)
        {
            Debug.Print("execution: " + file + " " + string.Join(" ", args));
            Process p = new Process();
            ProcessStartInfo processStartInfo = new ProcessStartInfo();
            processStartInfo.WorkingDirectory = this.project.Path;
            processStartInfo.CreateNoWindow = true;
            processStartInfo.UseShellExecute = false;
            processStartInfo.FileName = file;
            processStartInfo.Arguments = string.Join(" ", args);
            processStartInfo.RedirectStandardError = true;
            processStartInfo.RedirectStandardOutput = true;
            p.StartInfo = processStartInfo;
            p.Start();
            p.WaitForExit();

            this.Output = p.StandardOutput.ReadToEnd();
            this.Error = p.StandardError.ReadToEnd();
            Debug.Print(this.Output);
            Debug.Print(this.Error);
            Debug.Print("Exitcode=" + p.ExitCode);
            return p.ExitCode;
        }
    }
}
