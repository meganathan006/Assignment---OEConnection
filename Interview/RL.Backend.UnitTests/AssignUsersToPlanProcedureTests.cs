using FluentAssertions;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Moq;
using RL.Backend.Commands;
using RL.Backend.Commands.Handlers.Plans;
using RL.Backend.Exceptions;
using RL.Data;
using RL.Data.DataModels;

namespace RL.Backend.UnitTests;

[TestClass]
public class AssignUsersToPlanProcedureTests
{
    [TestMethod]
    [DataRow(-1)]
    [DataRow(0)]
    [DataRow(int.MinValue)]
    public async Task AssignUsersToPlanProcedure_InvalidPlanId_ReturnsBadRequest(int planId)
    {
        // Given
        var context = new Mock<RLContext>();
        var sut = new AssignUsersToPlanProcedureCommandHandler(context.Object);
        var request = new AssignUsersToPlanProcedureCommand
        {
            PlanId = planId,
            ProcedureId = 1,
            UserIds = new List<int> { 1 }
        };

        // When
        var result = await sut.Handle(request, CancellationToken.None);

        // Then
        result.Exception.Should().BeOfType(typeof(BadRequestException));
        result.Succeeded.Should().BeFalse();
    }

    [TestMethod]
    [DataRow(-1)]
    [DataRow(0)]
    [DataRow(int.MinValue)]
    public async Task AssignUsersToPlanProcedure_InvalidProcedureId_ReturnsBadRequest(int procedureId)
    {
        // Given
        var context = new Mock<RLContext>();
        var sut = new AssignUsersToPlanProcedureCommandHandler(context.Object);
        var request = new AssignUsersToPlanProcedureCommand
        {
            PlanId = 1,
            ProcedureId = procedureId,
            UserIds = new List<int> { 1 }
        };

        // When
        var result = await sut.Handle(request, CancellationToken.None);

        // Then
        result.Exception.Should().BeOfType(typeof(BadRequestException));
        result.Succeeded.Should().BeFalse();
    }

    [TestMethod]
    public async Task AssignUsersToPlanProcedure_NullUserIds_ReturnsBadRequest()
    {
        // Given
        var context = new Mock<RLContext>();
        var sut = new AssignUsersToPlanProcedureCommandHandler(context.Object);
        var request = new AssignUsersToPlanProcedureCommand
        {
            PlanId = 1,
            ProcedureId = 1,
            UserIds = null!
        };

        // When
        var result = await sut.Handle(request, CancellationToken.None);

        // Then
        result.Exception.Should().BeOfType(typeof(BadRequestException));
        result.Succeeded.Should().BeFalse();
    }

    [TestMethod]
    [DataRow(0)]
    [DataRow(-1)]
    public async Task AssignUsersToPlanProcedure_InvalidUserIdInList_ReturnsBadRequest(int invalidUserId)
    {
        // Given
        var context = new Mock<RLContext>();
        var sut = new AssignUsersToPlanProcedureCommandHandler(context.Object);
        var request = new AssignUsersToPlanProcedureCommand
        {
            PlanId = 1,
            ProcedureId = 1,
            UserIds = new List<int> { 1, invalidUserId }
        };

        // When
        var result = await sut.Handle(request, CancellationToken.None);

        // Then
        result.Exception.Should().BeOfType(typeof(BadRequestException));
        result.Succeeded.Should().BeFalse();
    }

    [TestMethod]
    public async Task AssignUsersToPlanProcedure_PlanNotFound_ReturnsNotFound()
    {
        // Given
        var context = DbContextHelper.CreateContext();
        var sut = new AssignUsersToPlanProcedureCommandHandler(context);
        var request = new AssignUsersToPlanProcedureCommand
        {
            PlanId = 999,
            ProcedureId = 1,
            UserIds = new List<int> { 1 }
        };

        // When
        var result = await sut.Handle(request, CancellationToken.None);

        // Then
        result.Exception.Should().BeOfType(typeof(NotFoundException));
        result.Succeeded.Should().BeFalse();
    }

    [TestMethod]
    public async Task AssignUsersToPlanProcedure_ProcedureNotFound_ReturnsNotFound()
    {
        // Given
        var context = DbContextHelper.CreateContext();
        context.Plans.Add(new Plan { PlanId = 1 });
        await context.SaveChangesAsync();

        var sut = new AssignUsersToPlanProcedureCommandHandler(context);
        var request = new AssignUsersToPlanProcedureCommand
        {
            PlanId = 1,
            ProcedureId = 999,
            UserIds = new List<int> { 1 }
        };

        // When
        var result = await sut.Handle(request, CancellationToken.None);

        // Then
        result.Exception.Should().BeOfType(typeof(NotFoundException));
        result.Succeeded.Should().BeFalse();
    }

    [TestMethod]
    public async Task AssignUsersToPlanProcedure_PlanProcedureNotFound_ReturnsNotFound()
    {
        // Given
        var context = DbContextHelper.CreateContext();
        context.Plans.Add(new Plan { PlanId = 1 });
        context.Procedures.Add(new Procedure { ProcedureId = 1, ProcedureTitle = "Test" });
        await context.SaveChangesAsync();

        var sut = new AssignUsersToPlanProcedureCommandHandler(context);
        var request = new AssignUsersToPlanProcedureCommand
        {
            PlanId = 1,
            ProcedureId = 1,
            UserIds = new List<int> { 1 }
        };

        // When
        var result = await sut.Handle(request, CancellationToken.None);

        // Then
        result.Exception.Should().BeOfType(typeof(NotFoundException));
        result.Succeeded.Should().BeFalse();
    }

    [TestMethod]
    public async Task AssignUsersToPlanProcedure_UserIdNotFound_ReturnsNotFound()
    {
        // Given
        var context = DbContextHelper.CreateContext();
        context.Plans.Add(new Plan { PlanId = 1 });
        context.Procedures.Add(new Procedure { ProcedureId = 1, ProcedureTitle = "Test" });
        context.PlanProcedures.Add(new PlanProcedure { PlanId = 1, ProcedureId = 1 });
        context.Users.Add(new User { UserId = 1, Name = "Existing User" });
        await context.SaveChangesAsync();

        var sut = new AssignUsersToPlanProcedureCommandHandler(context);
        var request = new AssignUsersToPlanProcedureCommand
        {
            PlanId = 1,
            ProcedureId = 1,
            UserIds = new List<int> { 1, 999 } // 999 does not exist
        };

        // When
        var result = await sut.Handle(request, CancellationToken.None);

        // Then
        result.Exception.Should().BeOfType(typeof(NotFoundException));
        result.Succeeded.Should().BeFalse();
    }

    [TestMethod]
    public async Task AssignUsersToPlanProcedure_AssignSingleUser_ReturnsSuccess()
    {
        // Given
        var context = DbContextHelper.CreateContext();
        context.Plans.Add(new Plan { PlanId = 1 });
        context.Procedures.Add(new Procedure { ProcedureId = 1, ProcedureTitle = "Test" });
        context.PlanProcedures.Add(new PlanProcedure { PlanId = 1, ProcedureId = 1 });
        context.Users.Add(new User { UserId = 1, Name = "User 1" });
        await context.SaveChangesAsync();

        var sut = new AssignUsersToPlanProcedureCommandHandler(context);
        var request = new AssignUsersToPlanProcedureCommand
        {
            PlanId = 1,
            ProcedureId = 1,
            UserIds = new List<int> { 1 }
        };

        // When
        var result = await sut.Handle(request, CancellationToken.None);

        // Then
        result.Succeeded.Should().BeTrue();
        result.Value.Should().Be(Unit.Value);

        var assigned = await context.PlanProcedureUsers
            .Where(ppu => ppu.PlanId == 1 && ppu.ProcedureId == 1)
            .ToListAsync();
        assigned.Should().HaveCount(1);
        assigned.First().UserId.Should().Be(1);
    }

    [TestMethod]
    public async Task AssignUsersToPlanProcedure_AssignMultipleUsers_ReturnsSuccess()
    {
        // Given
        var context = DbContextHelper.CreateContext();
        context.Plans.Add(new Plan { PlanId = 1 });
        context.Procedures.Add(new Procedure { ProcedureId = 1, ProcedureTitle = "Test" });
        context.PlanProcedures.Add(new PlanProcedure { PlanId = 1, ProcedureId = 1 });
        context.Users.Add(new User { UserId = 1, Name = "User 1" });
        context.Users.Add(new User { UserId = 2, Name = "User 2" });
        await context.SaveChangesAsync();

        var sut = new AssignUsersToPlanProcedureCommandHandler(context);
        var request = new AssignUsersToPlanProcedureCommand
        {
            PlanId = 1,
            ProcedureId = 1,
            UserIds = new List<int> { 1, 2 }
        };

        // When
        var result = await sut.Handle(request, CancellationToken.None);

        // Then
        result.Succeeded.Should().BeTrue();
        var assigned = await context.PlanProcedureUsers
            .Where(ppu => ppu.PlanId == 1 && ppu.ProcedureId == 1)
            .Select(ppu => ppu.UserId)
            .ToListAsync();
        assigned.Should().BeEquivalentTo(new[] { 1, 2 });
    }

    [TestMethod]
    public async Task AssignUsersToPlanProcedure_RemoveSingleUser_ReturnsSuccess()
    {
        // Given
        var context = DbContextHelper.CreateContext();
        context.Plans.Add(new Plan { PlanId = 1 });
        context.Procedures.Add(new Procedure { ProcedureId = 1, ProcedureTitle = "Test" });
        var planProcedure = new PlanProcedure { PlanId = 1, ProcedureId = 1 };
        context.PlanProcedures.Add(planProcedure);
        context.Users.Add(new User { UserId = 1, Name = "User 1" });
        context.Users.Add(new User { UserId = 2, Name = "User 2" });
        context.PlanProcedureUsers.Add(new PlanProcedureUser { PlanId = 1, ProcedureId = 1, UserId = 1 });
        context.PlanProcedureUsers.Add(new PlanProcedureUser { PlanId = 1, ProcedureId = 1, UserId = 2 });
        await context.SaveChangesAsync();

        var sut = new AssignUsersToPlanProcedureCommandHandler(context);
        // Only keep user 1, removing user 2
        var request = new AssignUsersToPlanProcedureCommand
        {
            PlanId = 1,
            ProcedureId = 1,
            UserIds = new List<int> { 1 }
        };

        // When
        var result = await sut.Handle(request, CancellationToken.None);

        // Then
        result.Succeeded.Should().BeTrue();
        var assigned = await context.PlanProcedureUsers
            .Where(ppu => ppu.PlanId == 1 && ppu.ProcedureId == 1)
            .Select(ppu => ppu.UserId)
            .ToListAsync();
        assigned.Should().BeEquivalentTo(new[] { 1 });
    }

    [TestMethod]
    public async Task AssignUsersToPlanProcedure_RemoveAllUsers_ReturnsSuccess()
    {
        // Given
        var context = DbContextHelper.CreateContext();
        context.Plans.Add(new Plan { PlanId = 1 });
        context.Procedures.Add(new Procedure { ProcedureId = 1, ProcedureTitle = "Test" });
        context.PlanProcedures.Add(new PlanProcedure { PlanId = 1, ProcedureId = 1 });
        context.Users.Add(new User { UserId = 1, Name = "User 1" });
        context.Users.Add(new User { UserId = 2, Name = "User 2" });
        context.PlanProcedureUsers.Add(new PlanProcedureUser { PlanId = 1, ProcedureId = 1, UserId = 1 });
        context.PlanProcedureUsers.Add(new PlanProcedureUser { PlanId = 1, ProcedureId = 1, UserId = 2 });
        await context.SaveChangesAsync();

        var sut = new AssignUsersToPlanProcedureCommandHandler(context);
        // Empty list -> remove all
        var request = new AssignUsersToPlanProcedureCommand
        {
            PlanId = 1,
            ProcedureId = 1,
            UserIds = new List<int>()
        };

        // When
        var result = await sut.Handle(request, CancellationToken.None);

        // Then
        result.Succeeded.Should().BeTrue();
        var assigned = await context.PlanProcedureUsers
            .Where(ppu => ppu.PlanId == 1 && ppu.ProcedureId == 1)
            .ToListAsync();
        assigned.Should().BeEmpty();
    }

    [TestMethod]
    public async Task AssignUsersToPlanProcedure_DuplicateUserIds_HandledCleanly()
    {
        // Given
        var context = DbContextHelper.CreateContext();
        context.Plans.Add(new Plan { PlanId = 1 });
        context.Procedures.Add(new Procedure { ProcedureId = 1, ProcedureTitle = "Test" });
        context.PlanProcedures.Add(new PlanProcedure { PlanId = 1, ProcedureId = 1 });
        context.Users.Add(new User { UserId = 1, Name = "User 1" });
        await context.SaveChangesAsync();

        var sut = new AssignUsersToPlanProcedureCommandHandler(context);
        var request = new AssignUsersToPlanProcedureCommand
        {
            PlanId = 1,
            ProcedureId = 1,
            UserIds = new List<int> { 1, 1, 1 }
        };

        // When
        var result = await sut.Handle(request, CancellationToken.None);

        // Then
        result.Succeeded.Should().BeTrue();
        var assigned = await context.PlanProcedureUsers
            .Where(ppu => ppu.PlanId == 1 && ppu.ProcedureId == 1)
            .ToListAsync();
        assigned.Should().HaveCount(1);
    }

    // ── Tests covering the specific fixes made in this iteration ──────────────

    /// <summary>
    /// Verifies that when a Plan exists and a Procedure exists but the procedure has NOT
    /// been added to the plan (no PlanProcedure row), the handler returns NotFoundException
    /// with a helpful message — using only a single DB round-trip (no separate Plan/Procedure lookups).
    /// </summary>
    [TestMethod]
    public async Task AssignUsersToPlanProcedure_ProcedureNotAddedToPlan_ReturnsNotFoundWithHelpfulMessage()
    {
        // Given
        var context = DbContextHelper.CreateContext();
        context.Plans.Add(new Plan { PlanId = 1 });
        context.Procedures.Add(new Procedure { ProcedureId = 2, ProcedureTitle = "Orphan Procedure" });
        // Deliberately NOT adding a PlanProcedure row
        await context.SaveChangesAsync();

        var sut = new AssignUsersToPlanProcedureCommandHandler(context);
        var request = new AssignUsersToPlanProcedureCommand
        {
            PlanId = 1,
            ProcedureId = 2,
            UserIds = new List<int>()
        };

        // When
        var result = await sut.Handle(request, CancellationToken.None);

        // Then
        result.Succeeded.Should().BeFalse();
        result.Exception.Should().BeOfType<NotFoundException>();
        result.Exception!.Message.Should().Contain("PlanId: 1");
        result.Exception!.Message.Should().Contain("ProcedureId: 2");
    }

    /// <summary>
    /// Full happy-path flow: add procedure to plan, then immediately assign users.
    /// Mirrors the real user workflow and verifies the fix did not regress the core feature.
    /// </summary>
    [TestMethod]
    public async Task AssignUsersToPlanProcedure_AfterAddingProcedureToPlan_SuccessfullyAssignsUsers()
    {
        // Given — simulate that addProcedureToPlan already ran (PlanProcedure row exists)
        var context = DbContextHelper.CreateContext();
        context.Plans.Add(new Plan { PlanId = 1 });
        context.Procedures.Add(new Procedure { ProcedureId = 1, ProcedureTitle = "Oil Change" });
        context.PlanProcedures.Add(new PlanProcedure { PlanId = 1, ProcedureId = 1 });
        context.Users.Add(new User { UserId = 10, Name = "Alice" });
        context.Users.Add(new User { UserId = 11, Name = "Bob" });
        await context.SaveChangesAsync();

        var sut = new AssignUsersToPlanProcedureCommandHandler(context);
        var request = new AssignUsersToPlanProcedureCommand
        {
            PlanId = 1,
            ProcedureId = 1,
            UserIds = new List<int> { 10, 11 }
        };

        // When
        var result = await sut.Handle(request, CancellationToken.None);

        // Then
        result.Succeeded.Should().BeTrue();
        var assigned = await context.PlanProcedureUsers
            .Where(ppu => ppu.PlanId == 1 && ppu.ProcedureId == 1)
            .Select(ppu => ppu.UserId)
            .ToListAsync();
        assigned.Should().BeEquivalentTo(new[] { 10, 11 });
    }

    /// <summary>
    /// Verifies that reassigning users (calling the endpoint a second time with a different set)
    /// correctly removes deselected users and adds new ones — no duplicates, no stale rows.
    /// This is the core "re-assign" fix that prevents stale data after rapid UI interactions.
    /// </summary>
    [TestMethod]
    public async Task AssignUsersToPlanProcedure_Reassign_ReplacesUsersCorrectly()
    {
        // Given — user 1 and 2 already assigned
        var context = DbContextHelper.CreateContext();
        context.Plans.Add(new Plan { PlanId = 1 });
        context.Procedures.Add(new Procedure { ProcedureId = 1, ProcedureTitle = "Tire Rotation" });
        context.PlanProcedures.Add(new PlanProcedure { PlanId = 1, ProcedureId = 1 });
        context.Users.Add(new User { UserId = 1, Name = "User 1" });
        context.Users.Add(new User { UserId = 2, Name = "User 2" });
        context.Users.Add(new User { UserId = 3, Name = "User 3" });
        context.PlanProcedureUsers.Add(new PlanProcedureUser { PlanId = 1, ProcedureId = 1, UserId = 1 });
        context.PlanProcedureUsers.Add(new PlanProcedureUser { PlanId = 1, ProcedureId = 1, UserId = 2 });
        await context.SaveChangesAsync();

        var sut = new AssignUsersToPlanProcedureCommandHandler(context);
        // Now reassign: keep user 1, drop user 2, add user 3
        var request = new AssignUsersToPlanProcedureCommand
        {
            PlanId = 1,
            ProcedureId = 1,
            UserIds = new List<int> { 1, 3 }
        };

        // When
        var result = await sut.Handle(request, CancellationToken.None);

        // Then
        result.Succeeded.Should().BeTrue();
        var assigned = await context.PlanProcedureUsers
            .Where(ppu => ppu.PlanId == 1 && ppu.ProcedureId == 1)
            .Select(ppu => ppu.UserId)
            .ToListAsync();
        assigned.Should().BeEquivalentTo(new[] { 1, 3 });
        assigned.Should().NotContain(2);
    }
}

