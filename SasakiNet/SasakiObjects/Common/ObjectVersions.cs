using System.Collections.Generic;
using Sasaki.Common;
using System;

namespace Sasaki.Common;

/// <summary>
/// a simple view of all the data linked to an object 
/// </summary>
public class Versions : SasakiObject, IHaveRefs, IHaveName
{

  /// <inheritdoc />
  public List<string> items {get;set;} = new List<string>();


  /// <summary>
  /// optional name of the object being reference
  /// </summary>
  public string? name {get;set;} = "";
}

/// <summary>
/// An extensible wrapper for <see cref="Versions"/>  with <see cref="IObject"/>
/// </summary>
/// <typeparam name="TObj"></typeparam>
public abstract class ObjectVersions<TObj> : Versions where TObj : IObject
{

  /// <summary>
  /// the main function that will trigger any updates with setting object info 
  /// </summary>
  /// <param name="obj"></param>
  public virtual void Set(TObj obj)
  {
    var type = obj.GetType();

    if(typeof(IHaveId).IsAssignableFrom(type) && obj is IHaveId i)
    {
      appId = i.appId;
    }

    if(typeof(IHaveName).IsAssignableFrom(type) && obj is IHaveName n)
    {
      name = n.name;
    }
  }
}
