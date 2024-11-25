namespace WebApplication1.comment;

public record Comment(
    Guid Id,
    Guid GroupId,
    Guid AuthorId,
    string Content,
    DateTime CreatedAt,
    DateTime? UpdatedAt
);
