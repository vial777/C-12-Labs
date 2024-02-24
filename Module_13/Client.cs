
public class Client {
  public void fileGet(string[] list)
  {
    Console.WriteLine("Client " + GetHashCode());
    foreach (var item in list)
      Console.WriteLine(item);
  }

}