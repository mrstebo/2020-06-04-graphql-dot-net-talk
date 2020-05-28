import gql from 'graphql-tag';

export const ON_BOOK_REVIEW_ADDED = gql`
  subscription sub($bookId: ID!) {
    onBookReviewAdded(bookId: $bookId) {
      id
      name
      title
      content
      createdAt
    }
  }
`;
