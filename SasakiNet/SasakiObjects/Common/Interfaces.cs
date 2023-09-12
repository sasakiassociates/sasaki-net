namespace Sasaki.Common;

/// <summary>
/// The standard interface for sasaki object ™️
/// Extend this lil bad pup to build and connect an object with the standard sasaki objects suite
/// </summary>
/// <remarks>
/// This interfaces is meant to great a simple type identifier for our converters and apps to rely on.
/// We rely on the interface type so our different client apps have more flexibility with extending our object structure.
/// <para>
/// I would only recommend utilizing this interface if you are building a new sasaki object type.
/// There are pre made objects like <see cref="SasakiObject"/> that can be used for quick prototyping 
/// </para>
/// </remarks>
/// <example>
/// inherit the type with any base class type
/// <code>class WhatIsNotion : Mono, ISasakiObject{ }</code>
/// or extend it for more customization
/// <code>interface INoNotion : ISasakiObject{ }</code>
/// </example>
///
public interface IObject : IHaveId
{ }

/// <summary>
/// A simple interfaces to set application id's to our object types
/// </summary>
public interface IHaveId
{
  /// <summary>
  ///   Sasaki id in the format of <see cref="System.Guid" />
  /// </summary>
  string? appId {get;}
}

/// <summary>
///  why be lame, give it a name!
/// </summary>
public interface IHaveName
{
  /// <summary>
  ///   Simple name for any sasaki object type
  /// </summary>
  string? name {get;}
}



/// <summary>
/// a simple way of keeping track of a series of reference ids
/// </summary>
public interface IHaveRefs
{

  /// <summary>
  ///  A list of version ids to use for connection speckle data into view to
  /// </summary>
  public List<string> items {get;}
}
