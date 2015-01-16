﻿using System;
using iOS4Unity;
using NUnit.Framework;

#if !UNITY_EDITOR

[TestFixture]
public class UIDeviceTests 
{
	[Test]
	public void CurrentDevice()
	{
		var device = UIDevice.CurrentDevice;
		Assert.AreNotEqual(IntPtr.Zero, device.Handle);
	}

	[Test]
	public void CurrentDeviceDispose()
	{
		var device = UIDevice.CurrentDevice;
		device.Dispose();
	}

	[Test]
	public void BatteryLevel()
	{
		float level = UIDevice.CurrentDevice.BatteryLevel;
		Assert.AreNotEqual (0, level);
	}

    [Test]
    public void BatteryMonitoringEnabled()
    {
        var device = UIDevice.CurrentDevice;
        device.BatteryMonitoringEnabled = true;
        Assert.AreEqual(true, device.BatteryMonitoringEnabled);
    }

    [Test]
    public void BatteryState()
    {
        var device = UIDevice.CurrentDevice;
		Assert.AreNotEqual(UIDeviceBatteryState.Unknown, device.BatteryState);
    }

    [Test]
    public void GeneratesDeviceOrientationNotifications()
    {
		//Just make sure this doesn't crash
        bool generatesNotifications = UIDevice.CurrentDevice.GeneratesDeviceOrientationNotifications;
    }

    [Test]
    public void LocalizedModel()
    {
        string localizedModel = UIDevice.CurrentDevice.LocalizedModel;
        Assert.AreNotEqual(string.Empty, localizedModel);
    }

    [Test]
    public void Model()
    {
        string model = UIDevice.CurrentDevice.Model;
        Assert.AreNotEqual(string.Empty, model);
    }

    [Test]
    public void Name()
    {
        string name = UIDevice.CurrentDevice.Name;
        Assert.AreNotEqual(string.Empty, name);
    }
    
    [Test]
    public void Orientation()
    {
        var device = UIDevice.CurrentDevice;
		Assert.AreNotEqual(UIDeviceOrientation.Unknown, device.Orientation);
    }

    [Test]
    public void ProximityMonitoringEnabled()
    {
        var device = UIDevice.CurrentDevice;
        device.ProximityMonitoringEnabled = true;
        Assert.AreEqual(true, device.ProximityMonitoringEnabled);
    }

    [Test]
    public void ProximityState()
    {
        bool proximityState = UIDevice.CurrentDevice.ProximityState;
    }

    [Test]
    public void SystemName()
    {
        string systemName = UIDevice.CurrentDevice.SystemName;
        Assert.AreNotEqual(string.Empty, systemName);
    }

    [Test]
    public void SystemVersion()
    {
        string systemVersion = UIDevice.CurrentDevice.SystemVersion;
        Assert.AreNotEqual(string.Empty, systemVersion);
    }

    [Test]
    public void UserInterfaceIdiom()
    {
        var device = UIDevice.CurrentDevice;
        Assert.AreNotEqual(UIUserInterfaceIdiom.Unspecified, device.Orientation);
    }

}

#endif