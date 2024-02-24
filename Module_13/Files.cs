namespace Module_13
{
  public delegate void DoneHandler(string[] str);
  public class FindFiles
  {
    public string Dir { get; set; }
    public string Ext { get; set; }

    public event DoneHandler Done;

    public FindFiles(string dir, string ext)
    {
      Dir = dir;
      Ext = ext;
    }
    public void Find()
    {
      String[] set;
      if (Directory.Exists(Dir))
      {
        set = Directory.GetFiles(Dir, "*." + Ext, SearchOption.AllDirectories);
      }
      else set = new string[] { "Directory not found!" };
      Done?.Invoke(set);

    }
  }
}
