using Sasaki.Common;

namespace Sasaki.Geometry
{

  public interface ICloud : IHaveId
  {
    /// <summary>
    ///   The cloud of points to use
    /// </summary>
    public CloudPoint[] points { get; set; }
  }

}
