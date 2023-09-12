using Sasaki.Common;
using Sasaki.Geometry;
using System.Collections.Generic;

namespace Sasaki.Analysis;

/// <summary>
///   The main structure for organizing result data
/// </summary>
public interface IResultLayer 
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

public interface IResultCloud<TLayer> : ICloud where TLayer : IResultLayer
{
  /// <summary>
  ///   The view analysis data gathered
  /// </summary>
  public List<TLayer> layers {get;set;}
}

/// <summary>
/// 
/// </summary>
public interface IResultCloud : IResultCloud<IResultLayer>
{ }

/// <summary>
///   An interface for organizing <typeparamref name="TObject" /> into a singular grouped objects
/// </summary>
/// <typeparam name="TObject"></typeparam>
public interface IStudy<TObject> where TObject : IObject
{
  /// <summary>
  ///   A list of <typeparamref name="TObject" /> objects to group in a study
  /// </summary>
  public List<TObject> objects {get;set;}
}
