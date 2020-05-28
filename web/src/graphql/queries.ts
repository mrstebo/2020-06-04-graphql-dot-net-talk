import { gql } from 'apollo-boost';

export const GET_AUTHORS = gql`
  query {
    authors {
      id
      name
      imageUrl
      bookCount
    }
  }
`;

export const GET_BOOKS = gql`
  query {
    books {
      id
      name
      imageUrl

      author {
        name
      }
    }
  }
`;
