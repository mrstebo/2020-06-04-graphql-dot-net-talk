import gql from 'graphql-tag';

export const BOOK_REVIEW_SUBSCRIPTION = gql`
  subscription onBookReviewAdded($bookId: ID!) {
    onBookReviewAdded(bookId: $bookId) {
      name
      title
      content
      createdAt
    }
  }
`;
