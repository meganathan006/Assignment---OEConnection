using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RL.Data.Migrations
{
    public partial class InsertProcedures : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Procedures",
                keyColumn: "ProcedureId",
                keyValue: 101);

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ProcedureId",
                keyValue: 1,
                column: "ProcedureTitle",
                value: "Front Seat Control Switch - Removal and Installation - Front Seats");

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ProcedureId",
                keyValue: 2,
                column: "ProcedureTitle",
                value: "Fuel Level Sender - Removal and Installation - Fuel Tank and Lines - 3.0L Power Stroke Diesel");

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ProcedureId",
                keyValue: 3,
                column: "ProcedureTitle",
                value: "Specifications - Specifications - Suspension System - General Information");

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ProcedureId",
                keyValue: 4,
                column: "ProcedureTitle",
                value: "Complete Panel Replacement/Partial Replacement - Description and Operation - Body Repairs - General Information");

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ProcedureId",
                keyValue: 5,
                column: "ProcedureTitle",
                value: "Turbocharger LH - Removal and Installation - Fuel Charging and Controls - Turbocharger - 3.5L EcoBoost (272kW/370PS)");

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ProcedureId",
                keyValue: 6,
                column: "ProcedureTitle",
                value: "Front Center Seat Backrest Latch - Removal and Installation - Front Seats");

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ProcedureId",
                keyValue: 7,
                column: "ProcedureTitle",
                value: "Electronic Engine Controls - Component Location - Description and Operation - Electronic Engine Controls - 3.5L EcoBoost (272kW/370PS)");

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ProcedureId",
                keyValue: 8,
                column: "ProcedureTitle",
                value: "Rocker Panel Inner Reinforcement - Regular Cab - Removal and Installation - Side Panel Sheet Metal Repairs");

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ProcedureId",
                keyValue: 9,
                column: "ProcedureTitle",
                value: "Fuel System - Overview - Description and Operation - Fuel System - General Information - 3.5L EcoBoost (272kW/370PS)");

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ProcedureId",
                keyValue: 10,
                column: "ProcedureTitle",
                value: "Rear Shock Absorber - Removal and Installation - Rear Suspension");

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ProcedureId",
                keyValue: 11,
                column: "ProcedureTitle",
                value: "Fuel Charging and Controls - System Operation and Component Description - Description and Operation - Fuel Charging and Controls - 5.0L 32V Ti-VCT");

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ProcedureId",
                keyValue: 12,
                column: "ProcedureTitle",
                value: "Specifications - Specifications - Parking Aid - Vehicles With: Rear Parking Aid");

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ProcedureId",
                keyValue: 13,
                column: "ProcedureTitle",
                value: "\"Noise, Vibration and Harshness (NVH) - Description and Operation - Noise, Vibration and Harshness\"");

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ProcedureId",
                keyValue: 14,
                column: "ProcedureTitle",
                value: "Engine - Body On - Installation - Engine - 5.0L 32V Ti-VCT");

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ProcedureId",
                keyValue: 15,
                column: "ProcedureTitle",
                value: "Accessory Drive - Component Location - Description and Operation - Accessory Drive - 3.3L Duratec-V6");

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ProcedureId",
                keyValue: 16,
                column: "ProcedureTitle",
                value: "Fuel Charging and Controls - Component Location - Description and Operation - Fuel Charging and Controls - 3.3L Duratec-V6");

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ProcedureId",
                keyValue: 17,
                column: "ProcedureTitle",
                value: "Front Seats - Diagnosis and Testing - Front Seats");

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ProcedureId",
                keyValue: 18,
                column: "ProcedureTitle",
                value: "Autolamps - Diagnosis and Testing - Exterior Lighting");

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ProcedureId",
                keyValue: 19,
                column: "ProcedureTitle",
                value: "Speaker Audio Test - General Procedures - Information and Entertainment System - General Information - Vehicles With: SYNC");

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ProcedureId",
                keyValue: 20,
                column: "ProcedureTitle",
                value: "Brake Caliper - Removal and Installation - Rear Disc Brake");

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ProcedureId",
                keyValue: 21,
                column: "ProcedureTitle",
                value: "Charging System - 2.7L EcoBoost (238kW/324PS)/3.5L EcoBoost (272kW/370PS) - Diagnosis and Testing - Charging System - General Information");

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ProcedureId",
                keyValue: 22,
                column: "ProcedureTitle",
                value: "\"Hood Latch Release Handle - Removal and Installation - Handles, Locks, Latches and Entry Systems\"");

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ProcedureId",
                keyValue: 23,
                column: "ProcedureTitle",
                value: "Information and Entertainment System - Diagnosis and Testing - Information and Entertainment System - General Information - Vehicles Without: SYNC");

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ProcedureId",
                keyValue: 24,
                column: "ProcedureTitle",
                value: "Rear Seats - Overview - Description and Operation - Rear Seats");

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ProcedureId",
                keyValue: 25,
                column: "ProcedureTitle",
                value: "Tire Pressure Monitoring System (TPMS) - Overview - Description and Operation - Tire Pressure Monitoring System (TPMS)");

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ProcedureId",
                keyValue: 26,
                column: "ProcedureTitle",
                value: "Charge Air Cooler (CAC) Outlet Pipe - Removal and Installation - Intake Air Distribution and Filtering - 2.7L EcoBoost (238kW/324PS)");

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ProcedureId",
                keyValue: 27,
                column: "ProcedureTitle",
                value: "Coolant Pump - Removal and Installation - Engine Cooling - 3.3L Duratec-V6");

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ProcedureId",
                keyValue: 28,
                column: "ProcedureTitle",
                value: "Module Controlled Functions - System Operation and Component Description - Description and Operation - Multifunction Electronic Modules");

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ProcedureId",
                keyValue: 29,
                column: "ProcedureTitle",
                value: "Specifications - Specifications - Engine Ignition - 3.5L EcoBoost (272kW/370PS)");

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ProcedureId",
                keyValue: 30,
                column: "ProcedureTitle",
                value: "Exhaust Manifold LH - Removal and Installation - Engine - 3.5L EcoBoost (272kW/370PS)");

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ProcedureId",
                keyValue: 31,
                column: "ProcedureTitle",
                value: "Passive Anti-Theft System (PATS) - Overview - Description and Operation - Passive Anti-Theft System (PATS) - Vehicles With: Keyless Vehicle System");

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ProcedureId",
                keyValue: 32,
                column: "ProcedureTitle",
                value: "Wastegate Control Valve Solenoid - Removal and Installation - Fuel Charging and Controls - Turbocharger - 2.7L EcoBoost (238kW/324PS)");

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ProcedureId",
                keyValue: 33,
                column: "ProcedureTitle",
                value: "Side Curtain Airbag - Regular Cab - Removal and Installation - Supplemental Restraint System");

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ProcedureId",
                keyValue: 34,
                column: "ProcedureTitle",
                value: "Valve Cover RH - Raptor - Removal and Installation - Engine - 3.5L EcoBoost (272kW/370PS)");

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ProcedureId",
                keyValue: 35,
                column: "ProcedureTitle",
                value: "Rear Suspension - Diagnosis and Testing - Rear Suspension");

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ProcedureId",
                keyValue: 36,
                column: "ProcedureTitle",
                value: "Diesel Particulate Filter (DPF) Differential Pressure Sensor - Removal and Installation - Electronic Engine Controls - 3.0L Power Stroke Diesel");

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ProcedureId",
                keyValue: 37,
                column: "ProcedureTitle",
                value: "Crankshaft Position (CKP) Sensor - Removal and Installation - Electronic Engine Controls - 3.0L Power Stroke Diesel");

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ProcedureId",
                keyValue: 38,
                column: "ProcedureTitle",
                value: "\"Thermostatic Expansion Valve - 3.5L EcoBoost (272kW/370PS), Raptor - Removal and Installation - Climate Control System - General Information\"");

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ProcedureId",
                keyValue: 39,
                column: "ProcedureTitle",
                value: "Road Testing Vehicle - Diagnosis and Testing - Automatic Transmission - 6-Speed Automatic Transmission – 6R80");

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ProcedureId",
                keyValue: 40,
                column: "ProcedureTitle",
                value: "Engine - Body On - Removal - Engine - 2.7L EcoBoost (238kW/324PS)");

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ProcedureId",
                keyValue: 41,
                column: "ProcedureTitle",
                value: "Restraints Control Module (RCM) - Removal and Installation - Supplemental Restraint System");

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ProcedureId",
                keyValue: 42,
                column: "ProcedureTitle",
                value: "Specifications - Specifications - Generator and Regulator");

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ProcedureId",
                keyValue: 43,
                column: "ProcedureTitle",
                value: "Engine - Body Off - Removal - Engine - 3.0L Power Stroke Diesel");

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ProcedureId",
                keyValue: 44,
                column: "ProcedureTitle",
                value: "Transfer Case - Diagnosis and Testing - Transfer Case");

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ProcedureId",
                keyValue: 45,
                column: "ProcedureTitle",
                value: "Camshaft LH - Removal and Installation - Engine - 5.0L 32V Ti-VCT");

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ProcedureId",
                keyValue: 46,
                column: "ProcedureTitle",
                value: "Low One-Way Clutch Assembly - Diagnosis and Testing - Automatic Transmission - 10-Speed Automatic Transmission – 10R80");

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ProcedureId",
                keyValue: 47,
                column: "ProcedureTitle",
                value: "Pinpoint Test - DTC: M - Diagnosis and Testing - Supplemental Restraint System");

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ProcedureId",
                keyValue: 48,
                column: "ProcedureTitle",
                value: "Bodyside Moulding - Removal and Installation - Exterior Trim and Ornamentation");

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ProcedureId",
                keyValue: 49,
                column: "ProcedureTitle",
                value: "Body Mount Fastener - General Procedures - Full Frame and Body Mounting");

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ProcedureId",
                keyValue: 50,
                column: "ProcedureTitle",
                value: "Pinpoint Test - DTC: AP - Diagnosis and Testing - Supplemental Restraint System");

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ProcedureId",
                keyValue: 51,
                column: "ProcedureTitle",
                value: "Front Seat Cushion Blower Motor - Removal and Installation - Front Seats");

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ProcedureId",
                keyValue: 52,
                column: "ProcedureTitle",
                value: "Alternating Current (AC) Power Outlet Socket - Removal and Installation - Voltage Converter/Inverter");

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ProcedureId",
                keyValue: 53,
                column: "ProcedureTitle",
                value: "Downshift Paddle Switch - Removal and Installation - Automatic Transmission External Controls");

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ProcedureId",
                keyValue: 54,
                column: "ProcedureTitle",
                value: "Pinpoint Test - DTC: H - Diagnosis and Testing - Supplemental Restraint System");

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ProcedureId",
                keyValue: 55,
                column: "ProcedureTitle",
                value: "Engine Oil Draining and Filling - General Procedures - Engine - 2.7L EcoBoost (238kW/324PS)");

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ProcedureId",
                keyValue: 56,
                column: "ProcedureTitle",
                value: "Transmission - Installation - Automatic Transmission - 6-Speed Automatic Transmission – 6R80");

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ProcedureId",
                keyValue: 57,
                column: "ProcedureTitle",
                value: "Interior Rear View Mirror - Removal and Installation - Rear View Mirrors");

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ProcedureId",
                keyValue: 58,
                column: "ProcedureTitle",
                value: "Camshaft RH - Removal and Installation - Engine - 3.0L Power Stroke Diesel");

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ProcedureId",
                keyValue: 59,
                column: "ProcedureTitle",
                value: "Specifications - Specifications - Engine Ignition - 3.3L Duratec-V6");

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ProcedureId",
                keyValue: 60,
                column: "ProcedureTitle",
                value: "Specifications - Specifications - Engine - 2.7L EcoBoost (238kW/324PS)");

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ProcedureId",
                keyValue: 61,
                column: "ProcedureTitle",
                value: "Rear Door Alignment - SuperCab - General Procedures - Body Closures");

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ProcedureId",
                keyValue: 62,
                column: "ProcedureTitle",
                value: "High-Pressure Fuel Pump - Removal and Installation - Fuel Charging and Controls - 3.3L Duratec-V6");

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ProcedureId",
                keyValue: 63,
                column: "ProcedureTitle",
                value: "Roof Opening Panel Motor - Removal and Installation - Roof Opening Panel");

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ProcedureId",
                keyValue: 64,
                column: "ProcedureTitle",
                value: "Engine Ignition - Component Location - Description and Operation - Engine Ignition - 3.3L Duratec-V6");

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ProcedureId",
                keyValue: 65,
                column: "ProcedureTitle",
                value: "Inspection and Repair after a Supplemental Restraint System (SRS) Deployment - General Procedures - Supplemental Restraint System");

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ProcedureId",
                keyValue: 66,
                column: "ProcedureTitle",
                value: "Transmission Fluid Cooler - 3.0L Power Stroke Diesel - Removal and Installation - Transmission Cooling");

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ProcedureId",
                keyValue: 67,
                column: "ProcedureTitle",
                value: "Fuel Tank and Lines - Diagnosis and Testing - Fuel Tank and Lines - 3.5L EcoBoost (272kW/370PS)");

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ProcedureId",
                keyValue: 68,
                column: "ProcedureTitle",
                value: "Fuel Tank and Lines - Overview - Description and Operation - Fuel Tank and Lines - 5.0L 32V Ti-VCT");

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ProcedureId",
                keyValue: 69,
                column: "ProcedureTitle",
                value: "Intake Air Distribution and Filtering - Overview - Description and Operation - Intake Air Distribution and Filtering - 3.0L Power Stroke Diesel");

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ProcedureId",
                keyValue: 70,
                column: "ProcedureTitle",
                value: "Charge Air Cooler (CAC) Cleaning - Raptor - General Procedures - Intake Air Distribution and Filtering - 3.5L EcoBoost (272kW/370PS)");

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ProcedureId",
                keyValue: 71,
                column: "ProcedureTitle",
                value: "Cylinder Head - Disassembly and Assembly of Subassemblies - Engine - 3.0L Power Stroke Diesel");

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ProcedureId",
                keyValue: 72,
                column: "ProcedureTitle",
                value: "Corrosion Prevention - General Procedures - Body Repairs - General Information");

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ProcedureId",
                keyValue: 73,
                column: "ProcedureTitle",
                value: "Front Parking Aid Camera - Removal and Installation - Parking Aid - Vehicles With: Parking Aid Camera");

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ProcedureId",
                keyValue: 74,
                column: "ProcedureTitle",
                value: "\"Front Door Window Regulator and Motor - Vehicles With: Front Power Windows - Removal and Installation - Glass, Frames and Mechanisms\"");

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ProcedureId",
                keyValue: 75,
                column: "ProcedureTitle",
                value: "Cylinder Head - Body On - LH - Raptor - Removal - Engine - 3.5L EcoBoost (272kW/370PS)");

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ProcedureId",
                keyValue: 76,
                column: "ProcedureTitle",
                value: "Fuel Tank - Vehicles With: Police Pack - Removal and Installation - Fuel Tank and Lines - 3.5L EcoBoost (272kW/370PS)");

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ProcedureId",
                keyValue: 77,
                column: "ProcedureTitle",
                value: "Starter Motor - Removal and Installation - Starting System - 2.7L EcoBoost (238kW/324PS)");

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ProcedureId",
                keyValue: 78,
                column: "ProcedureTitle",
                value: "Engine Emission Control - Diagnosis and Testing - Engine Emission Control - 3.3L Duratec-V6");

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ProcedureId",
                keyValue: 79,
                column: "ProcedureTitle",
                value: "Specifications - Specifications - Starting System - 3.0L Power Stroke Diesel");

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ProcedureId",
                keyValue: 80,
                column: "ProcedureTitle",
                value: "Pinpoint Test - DTC: D - Diagnosis and Testing - Supplemental Restraint System");

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ProcedureId",
                keyValue: 81,
                column: "ProcedureTitle",
                value: "A Clutch - Diagnosis and Testing - Automatic Transmission - 10-Speed Automatic Transmission – 10R80");

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ProcedureId",
                keyValue: 82,
                column: "ProcedureTitle",
                value: "Pinpoint Test - DTC: K - Diagnosis and Testing - Supplemental Restraint System");

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ProcedureId",
                keyValue: 83,
                column: "ProcedureTitle",
                value: "Blower Motor Control Module - Removal and Installation - Climate Control System - General Information");

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ProcedureId",
                keyValue: 84,
                column: "ProcedureTitle",
                value: "Exhaust System - Diagnosis and Testing - Exhaust System - 2.7L EcoBoost (238kW/324PS)");

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ProcedureId",
                keyValue: 85,
                column: "ProcedureTitle",
                value: "Valve Cover RH - Removal and Installation - Engine - 5.0L 32V Ti-VCT");

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ProcedureId",
                keyValue: 86,
                column: "ProcedureTitle",
                value: "Selector Lever Cable - Raptor - Removal and Installation - Automatic Transmission External Controls");

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ProcedureId",
                keyValue: 87,
                column: "ProcedureTitle",
                value: "Turbocharger Oil Supply Tube RH - Raptor - Removal and Installation - Fuel Charging and Controls - Turbocharger - 3.5L EcoBoost (272kW/370PS)");

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ProcedureId",
                keyValue: 88,
                column: "ProcedureTitle",
                value: "Climate Control System - Vehicles With: Electronic Manual Temperature Control (EMTC) - Component Location - Description and Operation - Climate Control System - General Information");

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ProcedureId",
                keyValue: 89,
                column: "ProcedureTitle",
                value: "Pinpoint Test - DTC: AN - Diagnosis and Testing - Supplemental Restraint System");

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ProcedureId",
                keyValue: 90,
                column: "ProcedureTitle",
                value: "Accessory Drive - Component Location - Description and Operation - Accessory Drive - 3.5L EcoBoost (272kW/370PS)");

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ProcedureId",
                keyValue: 91,
                column: "ProcedureTitle",
                value: "\"Rear Door Glass Run and Bracket - SuperCrew - Removal and Installation - Glass, Frames and Mechanisms\"");

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ProcedureId",
                keyValue: 92,
                column: "ProcedureTitle",
                value: "About this Manual - Description and Operation - General Information");

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ProcedureId",
                keyValue: 93,
                column: "ProcedureTitle",
                value: "Engine Ignition - Diagnosis and Testing - Engine Ignition - 5.0L 32V Ti-VCT");

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ProcedureId",
                keyValue: 94,
                column: "ProcedureTitle",
                value: "Fuel Injection Pump - Removal and Installation - Fuel Charging and Controls - 3.0L Power Stroke Diesel");

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ProcedureId",
                keyValue: 95,
                column: "ProcedureTitle",
                value: "Glove Compartment - Removal and Installation - Instrument Panel and Console");

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ProcedureId",
                keyValue: 96,
                column: "ProcedureTitle",
                value: "Fuel Tank and Lines - Diagnosis and Testing - Fuel Tank and Lines - 3.0L Power Stroke Diesel");

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ProcedureId",
                keyValue: 97,
                column: "ProcedureTitle",
                value: "Fuel Rail Pressure and Temperature Sensor - Removal and Installation - Electronic Engine Controls - 3.5L EcoBoost (272kW/370PS)");

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ProcedureId",
                keyValue: 98,
                column: "ProcedureTitle",
                value: "Wheel and Tire Health and Safety Precautions - Description and Operation - General Information");

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ProcedureId",
                keyValue: 99,
                column: "ProcedureTitle",
                value: "Variable Camshaft Timing (VCT) Unit - Removal and Installation - Engine - 3.3L Duratec-V6");

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ProcedureId",
                keyValue: 100,
                column: "ProcedureTitle",
                value: "Piston Selection - General Procedures - Engine System - General Information");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ProcedureId",
                keyValue: 1,
                column: "ProcedureTitle",
                value: "Proceduretitle");

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ProcedureId",
                keyValue: 2,
                column: "ProcedureTitle",
                value: "Front Seat Control Switch - Removal and Installation - Front Seats");

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ProcedureId",
                keyValue: 3,
                column: "ProcedureTitle",
                value: "Fuel Level Sender - Removal and Installation - Fuel Tank and Lines - 3.0L Power Stroke Diesel");

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ProcedureId",
                keyValue: 4,
                column: "ProcedureTitle",
                value: "Specifications - Specifications - Suspension System - General Information");

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ProcedureId",
                keyValue: 5,
                column: "ProcedureTitle",
                value: "Complete Panel Replacement/Partial Replacement - Description and Operation - Body Repairs - General Information");

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ProcedureId",
                keyValue: 6,
                column: "ProcedureTitle",
                value: "Turbocharger LH - Removal and Installation - Fuel Charging and Controls - Turbocharger - 3.5L EcoBoost (272kW/370PS)");

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ProcedureId",
                keyValue: 7,
                column: "ProcedureTitle",
                value: "Front Center Seat Backrest Latch - Removal and Installation - Front Seats");

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ProcedureId",
                keyValue: 8,
                column: "ProcedureTitle",
                value: "Electronic Engine Controls - Component Location - Description and Operation - Electronic Engine Controls - 3.5L EcoBoost (272kW/370PS)");

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ProcedureId",
                keyValue: 9,
                column: "ProcedureTitle",
                value: "Rocker Panel Inner Reinforcement - Regular Cab - Removal and Installation - Side Panel Sheet Metal Repairs");

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ProcedureId",
                keyValue: 10,
                column: "ProcedureTitle",
                value: "Fuel System - Overview - Description and Operation - Fuel System - General Information - 3.5L EcoBoost (272kW/370PS)");

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ProcedureId",
                keyValue: 11,
                column: "ProcedureTitle",
                value: "Rear Shock Absorber - Removal and Installation - Rear Suspension");

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ProcedureId",
                keyValue: 12,
                column: "ProcedureTitle",
                value: "Fuel Charging and Controls - System Operation and Component Description - Description and Operation - Fuel Charging and Controls - 5.0L 32V Ti-VCT");

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ProcedureId",
                keyValue: 13,
                column: "ProcedureTitle",
                value: "Specifications - Specifications - Parking Aid - Vehicles With: Rear Parking Aid");

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ProcedureId",
                keyValue: 14,
                column: "ProcedureTitle",
                value: "\"Noise, Vibration and Harshness (NVH) - Description and Operation - Noise, Vibration and Harshness\"");

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ProcedureId",
                keyValue: 15,
                column: "ProcedureTitle",
                value: "Engine - Body On - Installation - Engine - 5.0L 32V Ti-VCT");

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ProcedureId",
                keyValue: 16,
                column: "ProcedureTitle",
                value: "Accessory Drive - Component Location - Description and Operation - Accessory Drive - 3.3L Duratec-V6");

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ProcedureId",
                keyValue: 17,
                column: "ProcedureTitle",
                value: "Fuel Charging and Controls - Component Location - Description and Operation - Fuel Charging and Controls - 3.3L Duratec-V6");

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ProcedureId",
                keyValue: 18,
                column: "ProcedureTitle",
                value: "Front Seats - Diagnosis and Testing - Front Seats");

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ProcedureId",
                keyValue: 19,
                column: "ProcedureTitle",
                value: "Autolamps - Diagnosis and Testing - Exterior Lighting");

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ProcedureId",
                keyValue: 20,
                column: "ProcedureTitle",
                value: "Speaker Audio Test - General Procedures - Information and Entertainment System - General Information - Vehicles With: SYNC");

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ProcedureId",
                keyValue: 21,
                column: "ProcedureTitle",
                value: "Brake Caliper - Removal and Installation - Rear Disc Brake");

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ProcedureId",
                keyValue: 22,
                column: "ProcedureTitle",
                value: "Charging System - 2.7L EcoBoost (238kW/324PS)/3.5L EcoBoost (272kW/370PS) - Diagnosis and Testing - Charging System - General Information");

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ProcedureId",
                keyValue: 23,
                column: "ProcedureTitle",
                value: "\"Hood Latch Release Handle - Removal and Installation - Handles, Locks, Latches and Entry Systems\"");

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ProcedureId",
                keyValue: 24,
                column: "ProcedureTitle",
                value: "Information and Entertainment System - Diagnosis and Testing - Information and Entertainment System - General Information - Vehicles Without: SYNC");

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ProcedureId",
                keyValue: 25,
                column: "ProcedureTitle",
                value: "Rear Seats - Overview - Description and Operation - Rear Seats");

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ProcedureId",
                keyValue: 26,
                column: "ProcedureTitle",
                value: "Tire Pressure Monitoring System (TPMS) - Overview - Description and Operation - Tire Pressure Monitoring System (TPMS)");

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ProcedureId",
                keyValue: 27,
                column: "ProcedureTitle",
                value: "Charge Air Cooler (CAC) Outlet Pipe - Removal and Installation - Intake Air Distribution and Filtering - 2.7L EcoBoost (238kW/324PS)");

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ProcedureId",
                keyValue: 28,
                column: "ProcedureTitle",
                value: "Coolant Pump - Removal and Installation - Engine Cooling - 3.3L Duratec-V6");

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ProcedureId",
                keyValue: 29,
                column: "ProcedureTitle",
                value: "Module Controlled Functions - System Operation and Component Description - Description and Operation - Multifunction Electronic Modules");

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ProcedureId",
                keyValue: 30,
                column: "ProcedureTitle",
                value: "Specifications - Specifications - Engine Ignition - 3.5L EcoBoost (272kW/370PS)");

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ProcedureId",
                keyValue: 31,
                column: "ProcedureTitle",
                value: "Exhaust Manifold LH - Removal and Installation - Engine - 3.5L EcoBoost (272kW/370PS)");

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ProcedureId",
                keyValue: 32,
                column: "ProcedureTitle",
                value: "Passive Anti-Theft System (PATS) - Overview - Description and Operation - Passive Anti-Theft System (PATS) - Vehicles With: Keyless Vehicle System");

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ProcedureId",
                keyValue: 33,
                column: "ProcedureTitle",
                value: "Wastegate Control Valve Solenoid - Removal and Installation - Fuel Charging and Controls - Turbocharger - 2.7L EcoBoost (238kW/324PS)");

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ProcedureId",
                keyValue: 34,
                column: "ProcedureTitle",
                value: "Side Curtain Airbag - Regular Cab - Removal and Installation - Supplemental Restraint System");

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ProcedureId",
                keyValue: 35,
                column: "ProcedureTitle",
                value: "Valve Cover RH - Raptor - Removal and Installation - Engine - 3.5L EcoBoost (272kW/370PS)");

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ProcedureId",
                keyValue: 36,
                column: "ProcedureTitle",
                value: "Rear Suspension - Diagnosis and Testing - Rear Suspension");

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ProcedureId",
                keyValue: 37,
                column: "ProcedureTitle",
                value: "Diesel Particulate Filter (DPF) Differential Pressure Sensor - Removal and Installation - Electronic Engine Controls - 3.0L Power Stroke Diesel");

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ProcedureId",
                keyValue: 38,
                column: "ProcedureTitle",
                value: "Crankshaft Position (CKP) Sensor - Removal and Installation - Electronic Engine Controls - 3.0L Power Stroke Diesel");

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ProcedureId",
                keyValue: 39,
                column: "ProcedureTitle",
                value: "\"Thermostatic Expansion Valve - 3.5L EcoBoost (272kW/370PS), Raptor - Removal and Installation - Climate Control System - General Information\"");

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ProcedureId",
                keyValue: 40,
                column: "ProcedureTitle",
                value: "Road Testing Vehicle - Diagnosis and Testing - Automatic Transmission - 6-Speed Automatic Transmission – 6R80");

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ProcedureId",
                keyValue: 41,
                column: "ProcedureTitle",
                value: "Engine - Body On - Removal - Engine - 2.7L EcoBoost (238kW/324PS)");

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ProcedureId",
                keyValue: 42,
                column: "ProcedureTitle",
                value: "Restraints Control Module (RCM) - Removal and Installation - Supplemental Restraint System");

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ProcedureId",
                keyValue: 43,
                column: "ProcedureTitle",
                value: "Specifications - Specifications - Generator and Regulator");

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ProcedureId",
                keyValue: 44,
                column: "ProcedureTitle",
                value: "Engine - Body Off - Removal - Engine - 3.0L Power Stroke Diesel");

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ProcedureId",
                keyValue: 45,
                column: "ProcedureTitle",
                value: "Transfer Case - Diagnosis and Testing - Transfer Case");

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ProcedureId",
                keyValue: 46,
                column: "ProcedureTitle",
                value: "Camshaft LH - Removal and Installation - Engine - 5.0L 32V Ti-VCT");

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ProcedureId",
                keyValue: 47,
                column: "ProcedureTitle",
                value: "Low One-Way Clutch Assembly - Diagnosis and Testing - Automatic Transmission - 10-Speed Automatic Transmission – 10R80");

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ProcedureId",
                keyValue: 48,
                column: "ProcedureTitle",
                value: "Pinpoint Test - DTC: M - Diagnosis and Testing - Supplemental Restraint System");

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ProcedureId",
                keyValue: 49,
                column: "ProcedureTitle",
                value: "Bodyside Moulding - Removal and Installation - Exterior Trim and Ornamentation");

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ProcedureId",
                keyValue: 50,
                column: "ProcedureTitle",
                value: "Body Mount Fastener - General Procedures - Full Frame and Body Mounting");

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ProcedureId",
                keyValue: 51,
                column: "ProcedureTitle",
                value: "Pinpoint Test - DTC: AP - Diagnosis and Testing - Supplemental Restraint System");

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ProcedureId",
                keyValue: 52,
                column: "ProcedureTitle",
                value: "Front Seat Cushion Blower Motor - Removal and Installation - Front Seats");

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ProcedureId",
                keyValue: 53,
                column: "ProcedureTitle",
                value: "Alternating Current (AC) Power Outlet Socket - Removal and Installation - Voltage Converter/Inverter");

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ProcedureId",
                keyValue: 54,
                column: "ProcedureTitle",
                value: "Downshift Paddle Switch - Removal and Installation - Automatic Transmission External Controls");

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ProcedureId",
                keyValue: 55,
                column: "ProcedureTitle",
                value: "Pinpoint Test - DTC: H - Diagnosis and Testing - Supplemental Restraint System");

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ProcedureId",
                keyValue: 56,
                column: "ProcedureTitle",
                value: "Engine Oil Draining and Filling - General Procedures - Engine - 2.7L EcoBoost (238kW/324PS)");

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ProcedureId",
                keyValue: 57,
                column: "ProcedureTitle",
                value: "Transmission - Installation - Automatic Transmission - 6-Speed Automatic Transmission – 6R80");

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ProcedureId",
                keyValue: 58,
                column: "ProcedureTitle",
                value: "Interior Rear View Mirror - Removal and Installation - Rear View Mirrors");

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ProcedureId",
                keyValue: 59,
                column: "ProcedureTitle",
                value: "Camshaft RH - Removal and Installation - Engine - 3.0L Power Stroke Diesel");

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ProcedureId",
                keyValue: 60,
                column: "ProcedureTitle",
                value: "Specifications - Specifications - Engine Ignition - 3.3L Duratec-V6");

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ProcedureId",
                keyValue: 61,
                column: "ProcedureTitle",
                value: "Specifications - Specifications - Engine - 2.7L EcoBoost (238kW/324PS)");

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ProcedureId",
                keyValue: 62,
                column: "ProcedureTitle",
                value: "Rear Door Alignment - SuperCab - General Procedures - Body Closures");

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ProcedureId",
                keyValue: 63,
                column: "ProcedureTitle",
                value: "High-Pressure Fuel Pump - Removal and Installation - Fuel Charging and Controls - 3.3L Duratec-V6");

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ProcedureId",
                keyValue: 64,
                column: "ProcedureTitle",
                value: "Roof Opening Panel Motor - Removal and Installation - Roof Opening Panel");

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ProcedureId",
                keyValue: 65,
                column: "ProcedureTitle",
                value: "Engine Ignition - Component Location - Description and Operation - Engine Ignition - 3.3L Duratec-V6");

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ProcedureId",
                keyValue: 66,
                column: "ProcedureTitle",
                value: "Inspection and Repair after a Supplemental Restraint System (SRS) Deployment - General Procedures - Supplemental Restraint System");

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ProcedureId",
                keyValue: 67,
                column: "ProcedureTitle",
                value: "Transmission Fluid Cooler - 3.0L Power Stroke Diesel - Removal and Installation - Transmission Cooling");

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ProcedureId",
                keyValue: 68,
                column: "ProcedureTitle",
                value: "Fuel Tank and Lines - Diagnosis and Testing - Fuel Tank and Lines - 3.5L EcoBoost (272kW/370PS)");

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ProcedureId",
                keyValue: 69,
                column: "ProcedureTitle",
                value: "Fuel Tank and Lines - Overview - Description and Operation - Fuel Tank and Lines - 5.0L 32V Ti-VCT");

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ProcedureId",
                keyValue: 70,
                column: "ProcedureTitle",
                value: "Intake Air Distribution and Filtering - Overview - Description and Operation - Intake Air Distribution and Filtering - 3.0L Power Stroke Diesel");

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ProcedureId",
                keyValue: 71,
                column: "ProcedureTitle",
                value: "Charge Air Cooler (CAC) Cleaning - Raptor - General Procedures - Intake Air Distribution and Filtering - 3.5L EcoBoost (272kW/370PS)");

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ProcedureId",
                keyValue: 72,
                column: "ProcedureTitle",
                value: "Cylinder Head - Disassembly and Assembly of Subassemblies - Engine - 3.0L Power Stroke Diesel");

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ProcedureId",
                keyValue: 73,
                column: "ProcedureTitle",
                value: "Corrosion Prevention - General Procedures - Body Repairs - General Information");

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ProcedureId",
                keyValue: 74,
                column: "ProcedureTitle",
                value: "Front Parking Aid Camera - Removal and Installation - Parking Aid - Vehicles With: Parking Aid Camera");

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ProcedureId",
                keyValue: 75,
                column: "ProcedureTitle",
                value: "\"Front Door Window Regulator and Motor - Vehicles With: Front Power Windows - Removal and Installation - Glass, Frames and Mechanisms\"");

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ProcedureId",
                keyValue: 76,
                column: "ProcedureTitle",
                value: "Cylinder Head - Body On - LH - Raptor - Removal - Engine - 3.5L EcoBoost (272kW/370PS)");

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ProcedureId",
                keyValue: 77,
                column: "ProcedureTitle",
                value: "Fuel Tank - Vehicles With: Police Pack - Removal and Installation - Fuel Tank and Lines - 3.5L EcoBoost (272kW/370PS)");

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ProcedureId",
                keyValue: 78,
                column: "ProcedureTitle",
                value: "Starter Motor - Removal and Installation - Starting System - 2.7L EcoBoost (238kW/324PS)");

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ProcedureId",
                keyValue: 79,
                column: "ProcedureTitle",
                value: "Engine Emission Control - Diagnosis and Testing - Engine Emission Control - 3.3L Duratec-V6");

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ProcedureId",
                keyValue: 80,
                column: "ProcedureTitle",
                value: "Specifications - Specifications - Starting System - 3.0L Power Stroke Diesel");

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ProcedureId",
                keyValue: 81,
                column: "ProcedureTitle",
                value: "Pinpoint Test - DTC: D - Diagnosis and Testing - Supplemental Restraint System");

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ProcedureId",
                keyValue: 82,
                column: "ProcedureTitle",
                value: "A Clutch - Diagnosis and Testing - Automatic Transmission - 10-Speed Automatic Transmission – 10R80");

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ProcedureId",
                keyValue: 83,
                column: "ProcedureTitle",
                value: "Pinpoint Test - DTC: K - Diagnosis and Testing - Supplemental Restraint System");

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ProcedureId",
                keyValue: 84,
                column: "ProcedureTitle",
                value: "Blower Motor Control Module - Removal and Installation - Climate Control System - General Information");

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ProcedureId",
                keyValue: 85,
                column: "ProcedureTitle",
                value: "Exhaust System - Diagnosis and Testing - Exhaust System - 2.7L EcoBoost (238kW/324PS)");

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ProcedureId",
                keyValue: 86,
                column: "ProcedureTitle",
                value: "Valve Cover RH - Removal and Installation - Engine - 5.0L 32V Ti-VCT");

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ProcedureId",
                keyValue: 87,
                column: "ProcedureTitle",
                value: "Selector Lever Cable - Raptor - Removal and Installation - Automatic Transmission External Controls");

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ProcedureId",
                keyValue: 88,
                column: "ProcedureTitle",
                value: "Turbocharger Oil Supply Tube RH - Raptor - Removal and Installation - Fuel Charging and Controls - Turbocharger - 3.5L EcoBoost (272kW/370PS)");

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ProcedureId",
                keyValue: 89,
                column: "ProcedureTitle",
                value: "Climate Control System - Vehicles With: Electronic Manual Temperature Control (EMTC) - Component Location - Description and Operation - Climate Control System - General Information");

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ProcedureId",
                keyValue: 90,
                column: "ProcedureTitle",
                value: "Pinpoint Test - DTC: AN - Diagnosis and Testing - Supplemental Restraint System");

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ProcedureId",
                keyValue: 91,
                column: "ProcedureTitle",
                value: "Accessory Drive - Component Location - Description and Operation - Accessory Drive - 3.5L EcoBoost (272kW/370PS)");

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ProcedureId",
                keyValue: 92,
                column: "ProcedureTitle",
                value: "\"Rear Door Glass Run and Bracket - SuperCrew - Removal and Installation - Glass, Frames and Mechanisms\"");

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ProcedureId",
                keyValue: 93,
                column: "ProcedureTitle",
                value: "About this Manual - Description and Operation - General Information");

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ProcedureId",
                keyValue: 94,
                column: "ProcedureTitle",
                value: "Engine Ignition - Diagnosis and Testing - Engine Ignition - 5.0L 32V Ti-VCT");

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ProcedureId",
                keyValue: 95,
                column: "ProcedureTitle",
                value: "Fuel Injection Pump - Removal and Installation - Fuel Charging and Controls - 3.0L Power Stroke Diesel");

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ProcedureId",
                keyValue: 96,
                column: "ProcedureTitle",
                value: "Glove Compartment - Removal and Installation - Instrument Panel and Console");

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ProcedureId",
                keyValue: 97,
                column: "ProcedureTitle",
                value: "Fuel Tank and Lines - Diagnosis and Testing - Fuel Tank and Lines - 3.0L Power Stroke Diesel");

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ProcedureId",
                keyValue: 98,
                column: "ProcedureTitle",
                value: "Fuel Rail Pressure and Temperature Sensor - Removal and Installation - Electronic Engine Controls - 3.5L EcoBoost (272kW/370PS)");

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ProcedureId",
                keyValue: 99,
                column: "ProcedureTitle",
                value: "Wheel and Tire Health and Safety Precautions - Description and Operation - General Information");

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "ProcedureId",
                keyValue: 100,
                column: "ProcedureTitle",
                value: "Variable Camshaft Timing (VCT) Unit - Removal and Installation - Engine - 3.3L Duratec-V6");

            migrationBuilder.InsertData(
                table: "Procedures",
                columns: new[] { "ProcedureId", "CreateDate", "ProcedureTitle", "UpdateDate" },
                values: new object[] { 101, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Piston Selection - General Procedures - Engine System - General Information", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });
        }
    }
}
