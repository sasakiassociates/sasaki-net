using Sasaki.Common;
using System.Collections.Generic;

namespace Sasaki.Analysis;

/// <summary>
///   The main structure for organizing result data
/// </summary>
public interface IResultLayer : IHaveId
{
  /// <summary>
  ///   the raw values gathered
  /// </summary>
  List<int> values {get;}
  /// <summary>
  ///   The Total point count value count within this layer
  /// </summary>
  public int count {get;}
}
