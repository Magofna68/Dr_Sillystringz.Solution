using System.Collections.Generic;

namespace Dr_Sillystringz.Models
{
  public class Machine
  {
    public Machine()
    {
      this.JoinEntities = new HashSet<EngineerMachine>();
    }

    public int MachineId { get; set; }
    public string Name { get; set; }
    public string Status { get; set; }
    public virtual ICollection<EngineerMachine> JoinEntities { get; set; }
  }
}