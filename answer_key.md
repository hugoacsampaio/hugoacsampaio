# Technical Screening Answer Key

## Snippet 1: Async/Await Execution Flow
**Tests:** Understanding of async/await execution order and Task handling

**Expected Output:**
```
Start
Middle
Work Complete
End
```

**Key Points to Look For:**
- Understanding that `DoWorkAsync()` starts executing immediately
- "Middle" prints before "Work Complete" because the task isn't awaited immediately
- No major issues in this code, but candidate might mention:
  - Could use `Task.Run` if CPU-bound work is needed
  - Could add error handling

## Snippet 2: LINQ Bug
**Tests:** LINQ query operations and debugging skills

**Bug:** The code uses `OrderBy` instead of `OrderByDescending`

**Correct Solution:**
```csharp
return students.Where(s => s.Score > 80)
              .OrderByDescending(s => s.Score)  // Fixed: OrderByDescending
              .Take(3)
              .ToList();
```

**Additional Issues to Discuss:**
- The Where clause filters before taking top 3, which might not be intended
- Might want to remove the Where clause to get absolute top 3 students

## Snippet 3: Dependency Injection
**Tests:** SOLID principles, specifically Dependency Inversion and Dependency Injection

**Pattern:** Dependency Injection / Inversion of Control

**Correct Solution:**
```csharp
public class UserService
{
    private readonly IEmailService _emailService;
    
    public UserService(IEmailService emailService)
    {
        _emailService = emailService;
    }
    
    public void NotifyUser(string email, string message)
    {
        _emailService.SendEmail(email, message);
    }
}
```

**Key Points:**
- Constructor injection
- Dependency on abstraction (interface) not concrete implementation
- Enables unit testing and loose coupling