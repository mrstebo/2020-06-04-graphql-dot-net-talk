import gql from 'graphql-tag';

export const CREATE_BOOK_REVIEW = gql`
  mutation($input: CreateBookReviewInput!) {
    createBookReview(input: $input) {
      id
    }
  }
`;
