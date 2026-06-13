string? region = null; 
// Console.WriteLine(region.ToUpper());

string? upperRegion = region?.ToUpper();
Console.WriteLine($"Region (conditional): {upperRegion}");

string displayRegion = region ?? "Unassigned";
Console.WriteLine($"Region (coalesced): {displayRegion}");

region ??= "Addis Ababa";
Console.WriteLine($"Region (assigned): {region}");


string studentName = "Abeba";
string studentId = "STU-001";
int enrollmentCount = 3;
decimal grantAmount = 1999.99m; // 'm' suffix marks a decimal literal
DateTime enrolledAt = DateTime.UtcNow;
string? campusRegion = null;

Console.WriteLine($"Student: {studentName} ({studentId})");
Console.WriteLine($"Courses: {enrollmentCount}");
Console.WriteLine($"Grant: {grantAmount:F2}");
Console.WriteLine($"Enrolled: {enrolledAt:yyyy-MM-dd}");
Console.WriteLine($"Campus: {campusRegion ?? "Not assigned"}");


// Legacy implementation — the bug that caused the audit failure
// double grantPerStudent = 1999.99;
// double totalAllocation = grantPerStudent * 100_000;

decimal grantPerStudent = 1999.99m;
decimal totalAllocation = grantPerStudent * 100_000m;

Console.WriteLine($"Total Allocated(Double): {totalAllocation}");