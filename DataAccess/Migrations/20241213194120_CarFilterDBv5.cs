using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class CarFilterDBv5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CarComfortDetails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CentralDoorLock = table.Column<bool>(type: "bit", nullable: false),
                    KeylessEntry = table.Column<bool>(type: "bit", nullable: false),
                    StartButton = table.Column<bool>(type: "bit", nullable: false),
                    ControlCircut = table.Column<bool>(type: "bit", nullable: false),
                    ElectricWindowsFront = table.Column<bool>(type: "bit", nullable: false),
                    ElectricWindowsBack = table.Column<bool>(type: "bit", nullable: false),
                    PowerSteering = table.Column<bool>(type: "bit", nullable: false),
                    CruiseControl = table.Column<bool>(type: "bit", nullable: false),
                    AirConditioning = table.Column<bool>(type: "bit", nullable: false),
                    ParkingSensors = table.Column<bool>(type: "bit", nullable: false),
                    ReverseCamera = table.Column<bool>(type: "bit", nullable: false),
                    ParkingMachine = table.Column<bool>(type: "bit", nullable: false),
                    StartStopSystem = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarComfortDetails", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CarExteriorDetails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IntervalWiper = table.Column<bool>(type: "bit", nullable: false),
                    AlloyWheels = table.Column<bool>(type: "bit", nullable: false),
                    RainSensor = table.Column<bool>(type: "bit", nullable: false),
                    SunRoof = table.Column<bool>(type: "bit", nullable: false),
                    PanoramicRoof = table.Column<bool>(type: "bit", nullable: false),
                    RoofRails = table.Column<bool>(type: "bit", nullable: false),
                    MettalicPaint = table.Column<bool>(type: "bit", nullable: false),
                    PaintedBumpers = table.Column<bool>(type: "bit", nullable: false),
                    TintedGlass = table.Column<bool>(type: "bit", nullable: false),
                    RearPrivacyGlass = table.Column<bool>(type: "bit", nullable: false),
                    ElectricMirrors = table.Column<bool>(type: "bit", nullable: false),
                    FoldingExteriorMirrors = table.Column<bool>(type: "bit", nullable: false),
                    FrontFogLights = table.Column<bool>(type: "bit", nullable: false),
                    XenonHeadLights = table.Column<bool>(type: "bit", nullable: false),
                    LedHeahlights = table.Column<bool>(type: "bit", nullable: false),
                    LedRearLighting = table.Column<bool>(type: "bit", nullable: false),
                    DayLights = table.Column<bool>(type: "bit", nullable: false),
                    HeadlampWasher = table.Column<bool>(type: "bit", nullable: false),
                    BurglarAlarm = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarExteriorDetails", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CarGeneralDetails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BodyType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Transmission = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NumberOfSeats = table.Column<int>(type: "int", nullable: false),
                    Segment = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DriveWheel = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FuelType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HorsePower = table.Column<int>(type: "int", nullable: false),
                    Torque = table.Column<int>(type: "int", nullable: false),
                    EngineCapacity = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Turbo = table.Column<bool>(type: "bit", nullable: false),
                    FuelTankCapacity = table.Column<int>(type: "int", nullable: false),
                    CargoCapacity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarGeneralDetails", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CarInteriorDetails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HeightAdjustmentSeat = table.Column<bool>(type: "bit", nullable: false),
                    ElectricAdjustmentSeat = table.Column<bool>(type: "bit", nullable: false),
                    HeatedSeats = table.Column<bool>(type: "bit", nullable: false),
                    VentilatedSeats = table.Column<bool>(type: "bit", nullable: false),
                    SportsSeat = table.Column<bool>(type: "bit", nullable: false),
                    AdjustableSteeringWheel = table.Column<bool>(type: "bit", nullable: false),
                    HeatedSteeringWheel = table.Column<bool>(type: "bit", nullable: false),
                    RearHeadrest = table.Column<bool>(type: "bit", nullable: false),
                    FoldingRearSeat = table.Column<bool>(type: "bit", nullable: false),
                    SlidingRearSeat = table.Column<bool>(type: "bit", nullable: false),
                    CentralArmRest = table.Column<bool>(type: "bit", nullable: false),
                    MakeUpMirror = table.Column<bool>(type: "bit", nullable: false),
                    AdjustableDashboardLighting = table.Column<bool>(type: "bit", nullable: false),
                    Tachometer = table.Column<bool>(type: "bit", nullable: false),
                    DayCounter = table.Column<bool>(type: "bit", nullable: false),
                    CoolantTemperatureGauge = table.Column<bool>(type: "bit", nullable: false),
                    OutsiteTemperatureGauge = table.Column<bool>(type: "bit", nullable: false),
                    BoardComputer = table.Column<bool>(type: "bit", nullable: false),
                    AudioSystem = table.Column<bool>(type: "bit", nullable: false),
                    DigitalRadio = table.Column<bool>(type: "bit", nullable: false),
                    AudioInput = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NavigationSystem = table.Column<int>(type: "int", nullable: false),
                    Bluetooth = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarInteriorDetails", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CarPerformanceDetails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TopSpeed = table.Column<int>(type: "int", nullable: false),
                    Acceleration = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UrbanConsumption = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Emmision = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PowerConsumption = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BatteryRange = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarPerformanceDetails", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CarSafetyDetails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ABS = table.Column<bool>(type: "bit", nullable: false),
                    BrakeAssist = table.Column<bool>(type: "bit", nullable: false),
                    EmergencyBraking = table.Column<bool>(type: "bit", nullable: false),
                    BlindSpotAssist = table.Column<bool>(type: "bit", nullable: false),
                    StabilityControl = table.Column<bool>(type: "bit", nullable: false),
                    TractionControl = table.Column<bool>(type: "bit", nullable: false),
                    DriverAirbag = table.Column<bool>(type: "bit", nullable: false),
                    PassangerAirbag = table.Column<bool>(type: "bit", nullable: false),
                    SideAirbag = table.Column<bool>(type: "bit", nullable: false),
                    HeadAirbag = table.Column<bool>(type: "bit", nullable: false),
                    KneeAirbag = table.Column<bool>(type: "bit", nullable: false),
                    LaneAirbag = table.Column<bool>(type: "bit", nullable: false),
                    FatigueSensor = table.Column<bool>(type: "bit", nullable: false),
                    TirePressureSensor = table.Column<bool>(type: "bit", nullable: false),
                    TrafficSignRecognition = table.Column<bool>(type: "bit", nullable: false),
                    CollisionWarningSystem = table.Column<bool>(type: "bit", nullable: false),
                    AutomaticLevelControl = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarSafetyDetails", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CarDetails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CarGeneralDetailId = table.Column<int>(type: "int", nullable: false),
                    CarPerformanceDetailId = table.Column<int>(type: "int", nullable: false),
                    CarSafetyDetailId = table.Column<int>(type: "int", nullable: false),
                    CarComfortDetailId = table.Column<int>(type: "int", nullable: false),
                    CarInteriorDetailId = table.Column<int>(type: "int", nullable: false),
                    CarExteriorDetailId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CarDetails_CarComfortDetails_CarComfortDetailId",
                        column: x => x.CarComfortDetailId,
                        principalTable: "CarComfortDetails",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CarDetails_CarExteriorDetails_CarExteriorDetailId",
                        column: x => x.CarExteriorDetailId,
                        principalTable: "CarExteriorDetails",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CarDetails_CarGeneralDetails_CarGeneralDetailId",
                        column: x => x.CarGeneralDetailId,
                        principalTable: "CarGeneralDetails",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CarDetails_CarInteriorDetails_CarInteriorDetailId",
                        column: x => x.CarInteriorDetailId,
                        principalTable: "CarInteriorDetails",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CarDetails_CarPerformanceDetails_CarPerformanceDetailId",
                        column: x => x.CarPerformanceDetailId,
                        principalTable: "CarPerformanceDetails",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CarDetails_CarSafetyDetails_CarSafetyDetailId",
                        column: x => x.CarSafetyDetailId,
                        principalTable: "CarSafetyDetails",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Cars",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CarDetailId = table.Column<int>(type: "int", nullable: false),
                    Brand = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Model = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Generation = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cars", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cars_CarDetails_CarDetailId",
                        column: x => x.CarDetailId,
                        principalTable: "CarDetails",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CarDetails_CarComfortDetailId",
                table: "CarDetails",
                column: "CarComfortDetailId");

            migrationBuilder.CreateIndex(
                name: "IX_CarDetails_CarExteriorDetailId",
                table: "CarDetails",
                column: "CarExteriorDetailId");

            migrationBuilder.CreateIndex(
                name: "IX_CarDetails_CarGeneralDetailId",
                table: "CarDetails",
                column: "CarGeneralDetailId");

            migrationBuilder.CreateIndex(
                name: "IX_CarDetails_CarInteriorDetailId",
                table: "CarDetails",
                column: "CarInteriorDetailId");

            migrationBuilder.CreateIndex(
                name: "IX_CarDetails_CarPerformanceDetailId",
                table: "CarDetails",
                column: "CarPerformanceDetailId");

            migrationBuilder.CreateIndex(
                name: "IX_CarDetails_CarSafetyDetailId",
                table: "CarDetails",
                column: "CarSafetyDetailId");

            migrationBuilder.CreateIndex(
                name: "IX_Cars_CarDetailId",
                table: "Cars",
                column: "CarDetailId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cars");

            migrationBuilder.DropTable(
                name: "CarDetails");

            migrationBuilder.DropTable(
                name: "CarComfortDetails");

            migrationBuilder.DropTable(
                name: "CarExteriorDetails");

            migrationBuilder.DropTable(
                name: "CarGeneralDetails");

            migrationBuilder.DropTable(
                name: "CarInteriorDetails");

            migrationBuilder.DropTable(
                name: "CarPerformanceDetails");

            migrationBuilder.DropTable(
                name: "CarSafetyDetails");
        }
    }
}
