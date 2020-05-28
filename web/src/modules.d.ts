declare module 'react-activity' {
  declare interface ActivityIndicatorProps {
    size?: number;
    color?: string;
    speed?: number;
    animating?: boolean;
  }

  declare class Dots extends React.Component<ActivityIndicatorProps, any> {}
  declare class Levels extends React.Component<ActivityIndicatorProps, any> {}
  declare class Sentry extends React.Component<ActivityIndicatorProps, any> {}
  declare class Spinner extends React.Component<ActivityIndicatorProps, any> {}
  declare class Squares extends React.Component<ActivityIndicatorProps, any> {}
  declare class Digital extends React.Component<ActivityIndicatorProps, any> {}
  declare class Bounce extends React.Component<ActivityIndicatorProps, any> {}
  declare class Windmill extends React.Component<ActivityIndicatorProps, any> {}
}
