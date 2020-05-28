import gql from 'graphql-tag';

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

export const GET_BOOK = gql`
  query($bookId: ID!) {
    book(id: $bookId) {
      name
      imageUrl
      description
      author {
        name
      }
      reviews {
        name
        title
        content
        createdAt
      }
    }
  }
`;
