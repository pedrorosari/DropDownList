namespace DropdownList.Models
{
    public class Department
    {
        public int id { get; set; }
        public string name { get; set; }

        public string [] dirs
        {
            get { return dirs; }
           
           
}

        public void Contratos()
        {
            Contratos(dirs);
        }

        public void Contratos(string[] dirs)
        {
            dirs = Directory.GetDirectories(@"c:\", "*", SearchOption.TopDirectoryOnly);

         

        }
      
        
       
}
}
