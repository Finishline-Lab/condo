// --------------------------------------------------------------------------------------------------------------------
// <copyright file="GitDiffHunk.cs" company="automotiveMastermind and contributors">
//   © automotiveMastermind and contributors. Licensed under MIT. See LICENSE and CREDITS for details.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace AM.Condo.IO
{
    using System.Collections.Generic;

    /// <summary>
    /// Represents a hunk, or collection of patches, associated with a git-diff operation on a file.
    /// /// </summary>
    public class GitDiffHunk
    {
        #region Properties and Indexers
        /// <summary>
        /// Gets the source of the hunk.
        /// </summary>
        public GitDiffHunkTarget From { get; } = new GitDiffHunkTarget();

        /// <summary>
        /// Gets the destination of the hunk.
        /// </summary>
        public GitDiffHunkTarget To { get; } = new GitDiffHunkTarget();

        /// <summary>
        /// Gets or sets the content of the hunk.
        /// </summary>
        public string Content { get; set; }

        /// <summary>
        /// Gets the collection of lines associated with the git-diff hunk.
        /// </summary>
        public ICollection<GitDiffLine> Lines { get; } = new HashSet<GitDiffLine>();
        #endregion
    }
}
