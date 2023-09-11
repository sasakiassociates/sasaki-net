using System.Collections.Generic;
using Sasaki.Geometry;

namespace Sasaki.Analysis;

public interface IResultCloud : IResultCloud<IResultLayer>
{ }

public interface IResultCloud<TLayer> : ICloud where TLayer : IResultLayer
{
  /// <summary>
  ///   The view analysis data gathered
  /// </summary>
  public List<TLayer> layers {get;set;}
}
