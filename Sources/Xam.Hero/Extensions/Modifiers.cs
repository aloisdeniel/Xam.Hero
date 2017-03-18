using System;
using System.Text;

namespace Lkzhao
{
	public class Modifiers
	{
		public class Modifier
		{
			public Modifier()
			{
				builder = new StringBuilder();
			}

			public Modifier(string modifiersString)
			{
				builder = new StringBuilder(modifiersString);
			}

			private StringBuilder builder = new StringBuilder();

			public string String => builder.ToString();

			private Modifier Append(string modifier)
			{
				if (builder.Length > 0) builder.Append(" ");
				builder.Append(modifier);
				return this;
			}

			public Modifier Fade() => this.Append("fade");

			public Modifier UseOptimizedSnapshot() => this.Append("useOptimizedSnapshot");

			public Modifier UseNormalSnapshot() => this.Append("useNormalSnapshot");

			public Modifier UseLayerRenderSnapshot() => this.Append("useLayerRenderSnapshot");

			public Modifier UseNoSnapshot() => this.Append("useNoSnapshot");

			public Modifier IgnoreSubviewModifiers(bool ignore) => this.Append($"ignoreSubviewModifiers({(ignore ? "true" : "false")})");

			public Modifier UseGlobalCoordinateSpace() => this.Append("useGlobalCoordinateSpace");

			public Modifier UseSameParentCoordinateSpace() => this.Append("useSameParentCoordinateSpace");

			public Modifier Position(float x, float y) => this.Append($"position({x},{y})");

			public Modifier Size(float x, float y) => this.Append($"size({x},{y})");

			public Modifier Transform(float x, float y, float z) => this.Append($"transform({x},{y},{z})");

			public Modifier Perspective(float perspective) => this.Append($"perspective({perspective})");

			public Modifier Scale(float x, float y, float z = 1) => this.Append($"scale({x},{y},{z})");

			public Modifier Scale(float xy) => Scale(xy, xy);

			public Modifier Translate(float x, float y, float z = 0) => this.Append($"translate({x},{y},{z})");

			public Modifier Rotate(float x = 0, float y = 0, float z = 0) => this.Append($"rotate({x},{y},{z})");

			public Modifier Opacity(float opacity) => this.Append($"opacity({opacity})");

			public Modifier CornerRadius(float radius) => this.Append($"cornerRadius({radius})");

			public Modifier ZPosition(float z) => this.Append($"zPosition({z})");

			public Modifier ContentsRect(float x, float y, float w, float h) => this.Append($"contentsRect({x},{y},{w},{h})");

			public Modifier ContentScale(float scale) => this.Append($"contentsScale({scale})");

			public Modifier BorderWidth(float w) => this.Append($"borderWidth({w})");

			public Modifier Delay(float seconds) => this.Append($"delay({seconds})");

			public Modifier Duration(float seconds) => this.Append($"duration({seconds})");

			public Modifier Arc(float intensity = 1) => this.Append($"arc({intensity})");

			public Modifier Cascade() => this.Append($"cascade");

			public Modifier Spring(float stiffness, float damping) => this.Append($"spring({stiffness},{damping})");
		}

		public static Modifier Fade() => new Modifier().Fade();

		public static Modifier Position(float x, float y) => new Modifier().Position(x, y);

		public static Modifier Size(float x, float y) => new Modifier().Size(x, y);

		public static Modifier Transform(float x, float y, float z) => new Modifier().Transform(x, y, z);

		public static Modifier Perspective(float perspective) => new Modifier().Perspective(perspective);

		public static Modifier Scale(float x, float y, float z = 1) => new Modifier().Scale(x, y, z);

		public static Modifier Scale(float xy) => new Modifier().Scale(xy);

		public static Modifier Translate(float x, float y, float z = 0) => new Modifier().Translate(x, y, z);

		public static Modifier Rotate(float x = 0, float y = 0, float z = 0) => new Modifier().Rotate(x, y, z);

		public static Modifier Opacity(float opacity) => new Modifier().Opacity(opacity);

		public static Modifier CornerRadius(float radius) => new Modifier().CornerRadius(radius);

		public static Modifier ZPosition(float z) => new Modifier().ZPosition(z);

		public static Modifier ContentsRect(float x, float y, float w, float h) => new Modifier().ContentsRect(x, y, w, h);

		public static Modifier ContentScale(float scale) => new Modifier().ZPosition(scale);

		public static Modifier BorderWidth(float w) => new Modifier().BorderWidth(w);

		public static Modifier Delay(float seconds) => new Modifier().Delay(seconds);

		public static Modifier Duration(float seconds) => new Modifier().Duration(seconds);

		public static Modifier Arc(float intensity = 1) => new Modifier().Arc(intensity);

		public static Modifier Cascade() => new Modifier().Cascade();

		public static Modifier Spring(float stiffness, float damping) => new Modifier().Spring(stiffness, damping);
	}

}
