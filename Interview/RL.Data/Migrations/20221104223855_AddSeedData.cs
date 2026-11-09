using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RL.Data.Migrations
{
    public partial class AddSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Procedures",
                columns: new[] { "ProcedureId", "CreateDate", "ProcedureTitle", "UpdateDate" },
                values: new object[] { 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Proceduretitle", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Procedures",
                columns: new[] { "ProcedureId", "CreateDate", "ProcedureTitle", "UpdateDate" },
                values: new object[] { 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Front Seat Control Switch - Removal and Installation - Front Seats", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Procedures",
                columns: new[] { "ProcedureId", "CreateDate", "ProcedureTitle", "UpdateDate" },
                values: new object[] { 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fuel Level Sender - Removal and Installation - Fuel Tank and Lines - 3.0L Power Stroke Diesel", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Procedures",
                columns: new[] { "ProcedureId", "CreateDate", "ProcedureTitle", "UpdateDate" },
                values: new object[] { 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Specifications - Specifications - Suspension System - General Information", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Procedures",
                columns: new[] { "ProcedureId", "CreateDate", "ProcedureTitle", "UpdateDate" },
                values: new object[] { 5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Complete Panel Replacement/Partial Replacement - Description and Operation - Body Repairs - General Information", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Procedures",
                columns: new[] { "ProcedureId", "CreateDate", "ProcedureTitle", "UpdateDate" },
                values: new object[] { 6, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Turbocharger LH - Removal and Installation - Fuel Charging and Controls - Turbocharger - 3.5L EcoBoost (272kW/370PS)", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Procedures",
                columns: new[] { "ProcedureId", "CreateDate", "ProcedureTitle", "UpdateDate" },
                values: new object[] { 7, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Front Center Seat Backrest Latch - Removal and Installation - Front Seats", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Procedures",
                columns: new[] { "ProcedureId", "CreateDate", "ProcedureTitle", "UpdateDate" },
                values: new object[] { 8, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Electronic Engine Controls - Component Location - Description and Operation - Electronic Engine Controls - 3.5L EcoBoost (272kW/370PS)", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Procedures",
                columns: new[] { "ProcedureId", "CreateDate", "ProcedureTitle", "UpdateDate" },
                values: new object[] { 9, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rocker Panel Inner Reinforcement - Regular Cab - Removal and Installation - Side Panel Sheet Metal Repairs", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Procedures",
                columns: new[] { "ProcedureId", "CreateDate", "ProcedureTitle", "UpdateDate" },
                values: new object[] { 10, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fuel System - Overview - Description and Operation - Fuel System - General Information - 3.5L EcoBoost (272kW/370PS)", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Procedures",
                columns: new[] { "ProcedureId", "CreateDate", "ProcedureTitle", "UpdateDate" },
                values: new object[] { 11, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rear Shock Absorber - Removal and Installation - Rear Suspension", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Procedures",
                columns: new[] { "ProcedureId", "CreateDate", "ProcedureTitle", "UpdateDate" },
                values: new object[] { 12, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fuel Charging and Controls - System Operation and Component Description - Description and Operation - Fuel Charging and Controls - 5.0L 32V Ti-VCT", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Procedures",
                columns: new[] { "ProcedureId", "CreateDate", "ProcedureTitle", "UpdateDate" },
                values: new object[] { 13, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Specifications - Specifications - Parking Aid - Vehicles With: Rear Parking Aid", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Procedures",
                columns: new[] { "ProcedureId", "CreateDate", "ProcedureTitle", "UpdateDate" },
                values: new object[] { 14, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "\"Noise, Vibration and Harshness (NVH) - Description and Operation - Noise, Vibration and Harshness\"", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Procedures",
                columns: new[] { "ProcedureId", "CreateDate", "ProcedureTitle", "UpdateDate" },
                values: new object[] { 15, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Engine - Body On - Installation - Engine - 5.0L 32V Ti-VCT", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Procedures",
                columns: new[] { "ProcedureId", "CreateDate", "ProcedureTitle", "UpdateDate" },
                values: new object[] { 16, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Accessory Drive - Component Location - Description and Operation - Accessory Drive - 3.3L Duratec-V6", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Procedures",
                columns: new[] { "ProcedureId", "CreateDate", "ProcedureTitle", "UpdateDate" },
                values: new object[] { 17, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fuel Charging and Controls - Component Location - Description and Operation - Fuel Charging and Controls - 3.3L Duratec-V6", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Procedures",
                columns: new[] { "ProcedureId", "CreateDate", "ProcedureTitle", "UpdateDate" },
                values: new object[] { 18, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Front Seats - Diagnosis and Testing - Front Seats", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Procedures",
                columns: new[] { "ProcedureId", "CreateDate", "ProcedureTitle", "UpdateDate" },
                values: new object[] { 19, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Autolamps - Diagnosis and Testing - Exterior Lighting", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Procedures",
                columns: new[] { "ProcedureId", "CreateDate", "ProcedureTitle", "UpdateDate" },
                values: new object[] { 20, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Speaker Audio Test - General Procedures - Information and Entertainment System - General Information - Vehicles With: SYNC", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Procedures",
                columns: new[] { "ProcedureId", "CreateDate", "ProcedureTitle", "UpdateDate" },
                values: new object[] { 21, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Brake Caliper - Removal and Installation - Rear Disc Brake", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Procedures",
                columns: new[] { "ProcedureId", "CreateDate", "ProcedureTitle", "UpdateDate" },
                values: new object[] { 22, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Charging System - 2.7L EcoBoost (238kW/324PS)/3.5L EcoBoost (272kW/370PS) - Diagnosis and Testing - Charging System - General Information", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Procedures",
                columns: new[] { "ProcedureId", "CreateDate", "ProcedureTitle", "UpdateDate" },
                values: new object[] { 23, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "\"Hood Latch Release Handle - Removal and Installation - Handles, Locks, Latches and Entry Systems\"", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Procedures",
                columns: new[] { "ProcedureId", "CreateDate", "ProcedureTitle", "UpdateDate" },
                values: new object[] { 24, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Information and Entertainment System - Diagnosis and Testing - Information and Entertainment System - General Information - Vehicles Without: SYNC", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Procedures",
                columns: new[] { "ProcedureId", "CreateDate", "ProcedureTitle", "UpdateDate" },
                values: new object[] { 25, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rear Seats - Overview - Description and Operation - Rear Seats", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Procedures",
                columns: new[] { "ProcedureId", "CreateDate", "ProcedureTitle", "UpdateDate" },
                values: new object[] { 26, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tire Pressure Monitoring System (TPMS) - Overview - Description and Operation - Tire Pressure Monitoring System (TPMS)", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Procedures",
                columns: new[] { "ProcedureId", "CreateDate", "ProcedureTitle", "UpdateDate" },
                values: new object[] { 27, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Charge Air Cooler (CAC) Outlet Pipe - Removal and Installation - Intake Air Distribution and Filtering - 2.7L EcoBoost (238kW/324PS)", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Procedures",
                columns: new[] { "ProcedureId", "CreateDate", "ProcedureTitle", "UpdateDate" },
                values: new object[] { 28, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Coolant Pump - Removal and Installation - Engine Cooling - 3.3L Duratec-V6", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Procedures",
                columns: new[] { "ProcedureId", "CreateDate", "ProcedureTitle", "UpdateDate" },
                values: new object[] { 29, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Module Controlled Functions - System Operation and Component Description - Description and Operation - Multifunction Electronic Modules", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Procedures",
                columns: new[] { "ProcedureId", "CreateDate", "ProcedureTitle", "UpdateDate" },
                values: new object[] { 30, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Specifications - Specifications - Engine Ignition - 3.5L EcoBoost (272kW/370PS)", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Procedures",
                columns: new[] { "ProcedureId", "CreateDate", "ProcedureTitle", "UpdateDate" },
                values: new object[] { 31, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Exhaust Manifold LH - Removal and Installation - Engine - 3.5L EcoBoost (272kW/370PS)", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Procedures",
                columns: new[] { "ProcedureId", "CreateDate", "ProcedureTitle", "UpdateDate" },
                values: new object[] { 32, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Passive Anti-Theft System (PATS) - Overview - Description and Operation - Passive Anti-Theft System (PATS) - Vehicles With: Keyless Vehicle System", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Procedures",
                columns: new[] { "ProcedureId", "CreateDate", "ProcedureTitle", "UpdateDate" },
                values: new object[] { 33, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Wastegate Control Valve Solenoid - Removal and Installation - Fuel Charging and Controls - Turbocharger - 2.7L EcoBoost (238kW/324PS)", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Procedures",
                columns: new[] { "ProcedureId", "CreateDate", "ProcedureTitle", "UpdateDate" },
                values: new object[] { 34, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Side Curtain Airbag - Regular Cab - Removal and Installation - Supplemental Restraint System", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Procedures",
                columns: new[] { "ProcedureId", "CreateDate", "ProcedureTitle", "UpdateDate" },
                values: new object[] { 35, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Valve Cover RH - Raptor - Removal and Installation - Engine - 3.5L EcoBoost (272kW/370PS)", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Procedures",
                columns: new[] { "ProcedureId", "CreateDate", "ProcedureTitle", "UpdateDate" },
                values: new object[] { 36, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rear Suspension - Diagnosis and Testing - Rear Suspension", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Procedures",
                columns: new[] { "ProcedureId", "CreateDate", "ProcedureTitle", "UpdateDate" },
                values: new object[] { 37, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Diesel Particulate Filter (DPF) Differential Pressure Sensor - Removal and Installation - Electronic Engine Controls - 3.0L Power Stroke Diesel", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Procedures",
                columns: new[] { "ProcedureId", "CreateDate", "ProcedureTitle", "UpdateDate" },
                values: new object[] { 38, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Crankshaft Position (CKP) Sensor - Removal and Installation - Electronic Engine Controls - 3.0L Power Stroke Diesel", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Procedures",
                columns: new[] { "ProcedureId", "CreateDate", "ProcedureTitle", "UpdateDate" },
                values: new object[] { 39, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "\"Thermostatic Expansion Valve - 3.5L EcoBoost (272kW/370PS), Raptor - Removal and Installation - Climate Control System - General Information\"", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Procedures",
                columns: new[] { "ProcedureId", "CreateDate", "ProcedureTitle", "UpdateDate" },
                values: new object[] { 40, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Road Testing Vehicle - Diagnosis and Testing - Automatic Transmission - 6-Speed Automatic Transmission – 6R80", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Procedures",
                columns: new[] { "ProcedureId", "CreateDate", "ProcedureTitle", "UpdateDate" },
                values: new object[] { 41, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Engine - Body On - Removal - Engine - 2.7L EcoBoost (238kW/324PS)", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Procedures",
                columns: new[] { "ProcedureId", "CreateDate", "ProcedureTitle", "UpdateDate" },
                values: new object[] { 42, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Restraints Control Module (RCM) - Removal and Installation - Supplemental Restraint System", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Procedures",
                columns: new[] { "ProcedureId", "CreateDate", "ProcedureTitle", "UpdateDate" },
                values: new object[] { 43, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Specifications - Specifications - Generator and Regulator", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Procedures",
                columns: new[] { "ProcedureId", "CreateDate", "ProcedureTitle", "UpdateDate" },
                values: new object[] { 44, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Engine - Body Off - Removal - Engine - 3.0L Power Stroke Diesel", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Procedures",
                columns: new[] { "ProcedureId", "CreateDate", "ProcedureTitle", "UpdateDate" },
                values: new object[] { 45, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Transfer Case - Diagnosis and Testing - Transfer Case", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Procedures",
                columns: new[] { "ProcedureId", "CreateDate", "ProcedureTitle", "UpdateDate" },
                values: new object[] { 46, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Camshaft LH - Removal and Installation - Engine - 5.0L 32V Ti-VCT", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Procedures",
                columns: new[] { "ProcedureId", "CreateDate", "ProcedureTitle", "UpdateDate" },
                values: new object[] { 47, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Low One-Way Clutch Assembly - Diagnosis and Testing - Automatic Transmission - 10-Speed Automatic Transmission – 10R80", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Procedures",
                columns: new[] { "ProcedureId", "CreateDate", "ProcedureTitle", "UpdateDate" },
                values: new object[] { 48, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pinpoint Test - DTC: M - Diagnosis and Testing - Supplemental Restraint System", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Procedures",
                columns: new[] { "ProcedureId", "CreateDate", "ProcedureTitle", "UpdateDate" },
                values: new object[] { 49, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bodyside Moulding - Removal and Installation - Exterior Trim and Ornamentation", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Procedures",
                columns: new[] { "ProcedureId", "CreateDate", "ProcedureTitle", "UpdateDate" },
                values: new object[] { 50, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Body Mount Fastener - General Procedures - Full Frame and Body Mounting", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Procedures",
                columns: new[] { "ProcedureId", "CreateDate", "ProcedureTitle", "UpdateDate" },
                values: new object[] { 51, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pinpoint Test - DTC: AP - Diagnosis and Testing - Supplemental Restraint System", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Procedures",
                columns: new[] { "ProcedureId", "CreateDate", "ProcedureTitle", "UpdateDate" },
                values: new object[] { 52, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Front Seat Cushion Blower Motor - Removal and Installation - Front Seats", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Procedures",
                columns: new[] { "ProcedureId", "CreateDate", "ProcedureTitle", "UpdateDate" },
                values: new object[] { 53, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Alternating Current (AC) Power Outlet Socket - Removal and Installation - Voltage Converter/Inverter", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Procedures",
                columns: new[] { "ProcedureId", "CreateDate", "ProcedureTitle", "UpdateDate" },
                values: new object[] { 54, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Downshift Paddle Switch - Removal and Installation - Automatic Transmission External Controls", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Procedures",
                columns: new[] { "ProcedureId", "CreateDate", "ProcedureTitle", "UpdateDate" },
                values: new object[] { 55, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pinpoint Test - DTC: H - Diagnosis and Testing - Supplemental Restraint System", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Procedures",
                columns: new[] { "ProcedureId", "CreateDate", "ProcedureTitle", "UpdateDate" },
                values: new object[] { 56, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Engine Oil Draining and Filling - General Procedures - Engine - 2.7L EcoBoost (238kW/324PS)", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Procedures",
                columns: new[] { "ProcedureId", "CreateDate", "ProcedureTitle", "UpdateDate" },
                values: new object[] { 57, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Transmission - Installation - Automatic Transmission - 6-Speed Automatic Transmission – 6R80", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Procedures",
                columns: new[] { "ProcedureId", "CreateDate", "ProcedureTitle", "UpdateDate" },
                values: new object[] { 58, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Interior Rear View Mirror - Removal and Installation - Rear View Mirrors", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Procedures",
                columns: new[] { "ProcedureId", "CreateDate", "ProcedureTitle", "UpdateDate" },
                values: new object[] { 59, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Camshaft RH - Removal and Installation - Engine - 3.0L Power Stroke Diesel", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Procedures",
                columns: new[] { "ProcedureId", "CreateDate", "ProcedureTitle", "UpdateDate" },
                values: new object[] { 60, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Specifications - Specifications - Engine Ignition - 3.3L Duratec-V6", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Procedures",
                columns: new[] { "ProcedureId", "CreateDate", "ProcedureTitle", "UpdateDate" },
                values: new object[] { 61, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Specifications - Specifications - Engine - 2.7L EcoBoost (238kW/324PS)", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Procedures",
                columns: new[] { "ProcedureId", "CreateDate", "ProcedureTitle", "UpdateDate" },
                values: new object[] { 62, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rear Door Alignment - SuperCab - General Procedures - Body Closures", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Procedures",
                columns: new[] { "ProcedureId", "CreateDate", "ProcedureTitle", "UpdateDate" },
                values: new object[] { 63, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "High-Pressure Fuel Pump - Removal and Installation - Fuel Charging and Controls - 3.3L Duratec-V6", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Procedures",
                columns: new[] { "ProcedureId", "CreateDate", "ProcedureTitle", "UpdateDate" },
                values: new object[] { 64, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Roof Opening Panel Motor - Removal and Installation - Roof Opening Panel", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Procedures",
                columns: new[] { "ProcedureId", "CreateDate", "ProcedureTitle", "UpdateDate" },
                values: new object[] { 65, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Engine Ignition - Component Location - Description and Operation - Engine Ignition - 3.3L Duratec-V6", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Procedures",
                columns: new[] { "ProcedureId", "CreateDate", "ProcedureTitle", "UpdateDate" },
                values: new object[] { 66, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Inspection and Repair after a Supplemental Restraint System (SRS) Deployment - General Procedures - Supplemental Restraint System", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Procedures",
                columns: new[] { "ProcedureId", "CreateDate", "ProcedureTitle", "UpdateDate" },
                values: new object[] { 67, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Transmission Fluid Cooler - 3.0L Power Stroke Diesel - Removal and Installation - Transmission Cooling", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Procedures",
                columns: new[] { "ProcedureId", "CreateDate", "ProcedureTitle", "UpdateDate" },
                values: new object[] { 68, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fuel Tank and Lines - Diagnosis and Testing - Fuel Tank and Lines - 3.5L EcoBoost (272kW/370PS)", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Procedures",
                columns: new[] { "ProcedureId", "CreateDate", "ProcedureTitle", "UpdateDate" },
                values: new object[] { 69, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fuel Tank and Lines - Overview - Description and Operation - Fuel Tank and Lines - 5.0L 32V Ti-VCT", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Procedures",
                columns: new[] { "ProcedureId", "CreateDate", "ProcedureTitle", "UpdateDate" },
                values: new object[] { 70, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Intake Air Distribution and Filtering - Overview - Description and Operation - Intake Air Distribution and Filtering - 3.0L Power Stroke Diesel", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Procedures",
                columns: new[] { "ProcedureId", "CreateDate", "ProcedureTitle", "UpdateDate" },
                values: new object[] { 71, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Charge Air Cooler (CAC) Cleaning - Raptor - General Procedures - Intake Air Distribution and Filtering - 3.5L EcoBoost (272kW/370PS)", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Procedures",
                columns: new[] { "ProcedureId", "CreateDate", "ProcedureTitle", "UpdateDate" },
                values: new object[] { 72, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cylinder Head - Disassembly and Assembly of Subassemblies - Engine - 3.0L Power Stroke Diesel", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Procedures",
                columns: new[] { "ProcedureId", "CreateDate", "ProcedureTitle", "UpdateDate" },
                values: new object[] { 73, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Corrosion Prevention - General Procedures - Body Repairs - General Information", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Procedures",
                columns: new[] { "ProcedureId", "CreateDate", "ProcedureTitle", "UpdateDate" },
                values: new object[] { 74, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Front Parking Aid Camera - Removal and Installation - Parking Aid - Vehicles With: Parking Aid Camera", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Procedures",
                columns: new[] { "ProcedureId", "CreateDate", "ProcedureTitle", "UpdateDate" },
                values: new object[] { 75, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "\"Front Door Window Regulator and Motor - Vehicles With: Front Power Windows - Removal and Installation - Glass, Frames and Mechanisms\"", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Procedures",
                columns: new[] { "ProcedureId", "CreateDate", "ProcedureTitle", "UpdateDate" },
                values: new object[] { 76, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cylinder Head - Body On - LH - Raptor - Removal - Engine - 3.5L EcoBoost (272kW/370PS)", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Procedures",
                columns: new[] { "ProcedureId", "CreateDate", "ProcedureTitle", "UpdateDate" },
                values: new object[] { 77, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fuel Tank - Vehicles With: Police Pack - Removal and Installation - Fuel Tank and Lines - 3.5L EcoBoost (272kW/370PS)", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Procedures",
                columns: new[] { "ProcedureId", "CreateDate", "ProcedureTitle", "UpdateDate" },
                values: new object[] { 78, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Starter Motor - Removal and Installation - Starting System - 2.7L EcoBoost (238kW/324PS)", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Procedures",
                columns: new[] { "ProcedureId", "CreateDate", "ProcedureTitle", "UpdateDate" },
                values: new object[] { 79, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Engine Emission Control - Diagnosis and Testing - Engine Emission Control - 3.3L Duratec-V6", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Procedures",
                columns: new[] { "ProcedureId", "CreateDate", "ProcedureTitle", "UpdateDate" },
                values: new object[] { 80, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Specifications - Specifications - Starting System - 3.0L Power Stroke Diesel", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Procedures",
                columns: new[] { "ProcedureId", "CreateDate", "ProcedureTitle", "UpdateDate" },
                values: new object[] { 81, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pinpoint Test - DTC: D - Diagnosis and Testing - Supplemental Restraint System", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Procedures",
                columns: new[] { "ProcedureId", "CreateDate", "ProcedureTitle", "UpdateDate" },
                values: new object[] { 82, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A Clutch - Diagnosis and Testing - Automatic Transmission - 10-Speed Automatic Transmission – 10R80", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Procedures",
                columns: new[] { "ProcedureId", "CreateDate", "ProcedureTitle", "UpdateDate" },
                values: new object[] { 83, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pinpoint Test - DTC: K - Diagnosis and Testing - Supplemental Restraint System", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Procedures",
                columns: new[] { "ProcedureId", "CreateDate", "ProcedureTitle", "UpdateDate" },
                values: new object[] { 84, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Blower Motor Control Module - Removal and Installation - Climate Control System - General Information", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Procedures",
                columns: new[] { "ProcedureId", "CreateDate", "ProcedureTitle", "UpdateDate" },
                values: new object[] { 85, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Exhaust System - Diagnosis and Testing - Exhaust System - 2.7L EcoBoost (238kW/324PS)", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Procedures",
                columns: new[] { "ProcedureId", "CreateDate", "ProcedureTitle", "UpdateDate" },
                values: new object[] { 86, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Valve Cover RH - Removal and Installation - Engine - 5.0L 32V Ti-VCT", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Procedures",
                columns: new[] { "ProcedureId", "CreateDate", "ProcedureTitle", "UpdateDate" },
                values: new object[] { 87, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Selector Lever Cable - Raptor - Removal and Installation - Automatic Transmission External Controls", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Procedures",
                columns: new[] { "ProcedureId", "CreateDate", "ProcedureTitle", "UpdateDate" },
                values: new object[] { 88, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Turbocharger Oil Supply Tube RH - Raptor - Removal and Installation - Fuel Charging and Controls - Turbocharger - 3.5L EcoBoost (272kW/370PS)", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Procedures",
                columns: new[] { "ProcedureId", "CreateDate", "ProcedureTitle", "UpdateDate" },
                values: new object[] { 89, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Climate Control System - Vehicles With: Electronic Manual Temperature Control (EMTC) - Component Location - Description and Operation - Climate Control System - General Information", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Procedures",
                columns: new[] { "ProcedureId", "CreateDate", "ProcedureTitle", "UpdateDate" },
                values: new object[] { 90, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pinpoint Test - DTC: AN - Diagnosis and Testing - Supplemental Restraint System", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Procedures",
                columns: new[] { "ProcedureId", "CreateDate", "ProcedureTitle", "UpdateDate" },
                values: new object[] { 91, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Accessory Drive - Component Location - Description and Operation - Accessory Drive - 3.5L EcoBoost (272kW/370PS)", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Procedures",
                columns: new[] { "ProcedureId", "CreateDate", "ProcedureTitle", "UpdateDate" },
                values: new object[] { 92, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "\"Rear Door Glass Run and Bracket - SuperCrew - Removal and Installation - Glass, Frames and Mechanisms\"", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Procedures",
                columns: new[] { "ProcedureId", "CreateDate", "ProcedureTitle", "UpdateDate" },
                values: new object[] { 93, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "About this Manual - Description and Operation - General Information", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Procedures",
                columns: new[] { "ProcedureId", "CreateDate", "ProcedureTitle", "UpdateDate" },
                values: new object[] { 94, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Engine Ignition - Diagnosis and Testing - Engine Ignition - 5.0L 32V Ti-VCT", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Procedures",
                columns: new[] { "ProcedureId", "CreateDate", "ProcedureTitle", "UpdateDate" },
                values: new object[] { 95, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fuel Injection Pump - Removal and Installation - Fuel Charging and Controls - 3.0L Power Stroke Diesel", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Procedures",
                columns: new[] { "ProcedureId", "CreateDate", "ProcedureTitle", "UpdateDate" },
                values: new object[] { 96, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Glove Compartment - Removal and Installation - Instrument Panel and Console", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Procedures",
                columns: new[] { "ProcedureId", "CreateDate", "ProcedureTitle", "UpdateDate" },
                values: new object[] { 97, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fuel Tank and Lines - Diagnosis and Testing - Fuel Tank and Lines - 3.0L Power Stroke Diesel", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Procedures",
                columns: new[] { "ProcedureId", "CreateDate", "ProcedureTitle", "UpdateDate" },
                values: new object[] { 98, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fuel Rail Pressure and Temperature Sensor - Removal and Installation - Electronic Engine Controls - 3.5L EcoBoost (272kW/370PS)", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Procedures",
                columns: new[] { "ProcedureId", "CreateDate", "ProcedureTitle", "UpdateDate" },
                values: new object[] { 99, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Wheel and Tire Health and Safety Precautions - Description and Operation - General Information", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Procedures",
                columns: new[] { "ProcedureId", "CreateDate", "ProcedureTitle", "UpdateDate" },
                values: new object[] { 100, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Variable Camshaft Timing (VCT) Unit - Removal and Installation - Engine - 3.3L Duratec-V6", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Procedures",
                columns: new[] { "ProcedureId", "CreateDate", "ProcedureTitle", "UpdateDate" },
                values: new object[] { 101, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Piston Selection - General Procedures - Engine System - General Information", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "CreateDate", "Name", "UpdateDate" },
                values: new object[] { 1, new DateTime(1999, 12, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nick Morrison", new DateTime(1999, 12, 13, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "CreateDate", "Name", "UpdateDate" },
                values: new object[] { 2, new DateTime(1999, 12, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Scott Cassidy", new DateTime(1999, 12, 13, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "CreateDate", "Name", "UpdateDate" },
                values: new object[] { 3, new DateTime(1999, 12, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tony Bidner", new DateTime(1999, 12, 13, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "CreateDate", "Name", "UpdateDate" },
                values: new object[] { 4, new DateTime(1999, 12, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Patryk Skwarko", new DateTime(1999, 12, 13, 0, 0, 0, 0, DateTimeKind.Unspecified) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Procedures",
                keyColumn: "ProcedureId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Procedures",
                keyColumn: "ProcedureId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Procedures",
                keyColumn: "ProcedureId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Procedures",
                keyColumn: "ProcedureId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Procedures",
                keyColumn: "ProcedureId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Procedures",
                keyColumn: "ProcedureId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Procedures",
                keyColumn: "ProcedureId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Procedures",
                keyColumn: "ProcedureId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Procedures",
                keyColumn: "ProcedureId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Procedures",
                keyColumn: "ProcedureId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Procedures",
                keyColumn: "ProcedureId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Procedures",
                keyColumn: "ProcedureId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Procedures",
                keyColumn: "ProcedureId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Procedures",
                keyColumn: "ProcedureId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Procedures",
                keyColumn: "ProcedureId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Procedures",
                keyColumn: "ProcedureId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Procedures",
                keyColumn: "ProcedureId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Procedures",
                keyColumn: "ProcedureId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Procedures",
                keyColumn: "ProcedureId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Procedures",
                keyColumn: "ProcedureId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Procedures",
                keyColumn: "ProcedureId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Procedures",
                keyColumn: "ProcedureId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Procedures",
                keyColumn: "ProcedureId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Procedures",
                keyColumn: "ProcedureId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Procedures",
                keyColumn: "ProcedureId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Procedures",
                keyColumn: "ProcedureId",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Procedures",
                keyColumn: "ProcedureId",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Procedures",
                keyColumn: "ProcedureId",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Procedures",
                keyColumn: "ProcedureId",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Procedures",
                keyColumn: "ProcedureId",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Procedures",
                keyColumn: "ProcedureId",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Procedures",
                keyColumn: "ProcedureId",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Procedures",
                keyColumn: "ProcedureId",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Procedures",
                keyColumn: "ProcedureId",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Procedures",
                keyColumn: "ProcedureId",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Procedures",
                keyColumn: "ProcedureId",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Procedures",
                keyColumn: "ProcedureId",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Procedures",
                keyColumn: "ProcedureId",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Procedures",
                keyColumn: "ProcedureId",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Procedures",
                keyColumn: "ProcedureId",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Procedures",
                keyColumn: "ProcedureId",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Procedures",
                keyColumn: "ProcedureId",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Procedures",
                keyColumn: "ProcedureId",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Procedures",
                keyColumn: "ProcedureId",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Procedures",
                keyColumn: "ProcedureId",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Procedures",
                keyColumn: "ProcedureId",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Procedures",
                keyColumn: "ProcedureId",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Procedures",
                keyColumn: "ProcedureId",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Procedures",
                keyColumn: "ProcedureId",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Procedures",
                keyColumn: "ProcedureId",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Procedures",
                keyColumn: "ProcedureId",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Procedures",
                keyColumn: "ProcedureId",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Procedures",
                keyColumn: "ProcedureId",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Procedures",
                keyColumn: "ProcedureId",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Procedures",
                keyColumn: "ProcedureId",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Procedures",
                keyColumn: "ProcedureId",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Procedures",
                keyColumn: "ProcedureId",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Procedures",
                keyColumn: "ProcedureId",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Procedures",
                keyColumn: "ProcedureId",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Procedures",
                keyColumn: "ProcedureId",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Procedures",
                keyColumn: "ProcedureId",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Procedures",
                keyColumn: "ProcedureId",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Procedures",
                keyColumn: "ProcedureId",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Procedures",
                keyColumn: "ProcedureId",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Procedures",
                keyColumn: "ProcedureId",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Procedures",
                keyColumn: "ProcedureId",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Procedures",
                keyColumn: "ProcedureId",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Procedures",
                keyColumn: "ProcedureId",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Procedures",
                keyColumn: "ProcedureId",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Procedures",
                keyColumn: "ProcedureId",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Procedures",
                keyColumn: "ProcedureId",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Procedures",
                keyColumn: "ProcedureId",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Procedures",
                keyColumn: "ProcedureId",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Procedures",
                keyColumn: "ProcedureId",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Procedures",
                keyColumn: "ProcedureId",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Procedures",
                keyColumn: "ProcedureId",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Procedures",
                keyColumn: "ProcedureId",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Procedures",
                keyColumn: "ProcedureId",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Procedures",
                keyColumn: "ProcedureId",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Procedures",
                keyColumn: "ProcedureId",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Procedures",
                keyColumn: "ProcedureId",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Procedures",
                keyColumn: "ProcedureId",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Procedures",
                keyColumn: "ProcedureId",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Procedures",
                keyColumn: "ProcedureId",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Procedures",
                keyColumn: "ProcedureId",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Procedures",
                keyColumn: "ProcedureId",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Procedures",
                keyColumn: "ProcedureId",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Procedures",
                keyColumn: "ProcedureId",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Procedures",
                keyColumn: "ProcedureId",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Procedures",
                keyColumn: "ProcedureId",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Procedures",
                keyColumn: "ProcedureId",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Procedures",
                keyColumn: "ProcedureId",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Procedures",
                keyColumn: "ProcedureId",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Procedures",
                keyColumn: "ProcedureId",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Procedures",
                keyColumn: "ProcedureId",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Procedures",
                keyColumn: "ProcedureId",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Procedures",
                keyColumn: "ProcedureId",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Procedures",
                keyColumn: "ProcedureId",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Procedures",
                keyColumn: "ProcedureId",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Procedures",
                keyColumn: "ProcedureId",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Procedures",
                keyColumn: "ProcedureId",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 4);
        }
    }
}
